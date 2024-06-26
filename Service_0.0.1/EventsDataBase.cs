﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Service
{
    public class EventsDataBase
    {
        readonly User activeUser;
        static Dictionary<Guid, Event> Events;
        static Dictionary<Guid, List<Guid>> UserstoEvents;
        static List<Guid> UserEvents = new List<Guid>();
        static string pathtobaseevents = "data/bases/events.json";
        static string pathtobasuseridtoeventsid = "data/bases/usertoevents.json";
        static Server server = new Server();


        public EventsDataBase()
        {

        }
        public EventsDataBase(User activeuser)
        {
            activeUser = activeuser;
            LoadEvents();
        }

        private void SaveBase()
        {
            server.DownloadBases();
            StreamWriter write = new StreamWriter(pathtobaseevents, false);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            serializer.Serialize(write, Events);
            write.Close();
            StreamWriter writer = new StreamWriter(pathtobasuseridtoeventsid, false);
            serializer.Serialize(writer, UserstoEvents);
            writer.Close();
            server.UpdateBases();
        }
        private void LoadEvents()
        {
            if (File.Exists(pathtobaseevents))
            {
                StreamReader read = new StreamReader(pathtobaseevents);
                Events = JsonConvert.DeserializeObject<Dictionary<Guid, Event>>(read.ReadToEnd());
                read.Close();
                CheckRegesrationEnd();
                ReadUserstoEvents();
            }
            else
            {
                Events = new Dictionary<Guid, Event>();

            }
        }
        private void ReadUserstoEvents()
        {
            server.DownloadBases();
            if (File.Exists(pathtobasuseridtoeventsid))
            {
                StreamReader read = new StreamReader(pathtobasuseridtoeventsid);
                UserstoEvents = JsonConvert.DeserializeObject<Dictionary<Guid, List<Guid>>>(read.ReadToEnd());
                read.Close();
                if (UserstoEvents != null)
                {
                    if (UserstoEvents.ContainsKey(activeUser.Id))
                        foreach (var item in UserstoEvents[activeUser.Id])
                            UserEvents.Add(item);

                    CheckRegesrationEnd();
                }
                else
                {
                    UserstoEvents = new Dictionary<Guid, List<Guid>>();
                }
                server.UpdateBases();
            }
        }
        public void CheckRegesrationEnd()
        {
            foreach (var item in Events)
            {
                if (item.Value.DataEndRegestration <= DateTime.Now)
                    item.Value.StatusRegestration = false;
            }
        }
        public void AddEvent(Event ev)
        {
            Events.Add(ev.Id, ev);

            if (UserstoEvents.ContainsKey(activeUser.Id))
            {
                UserstoEvents[activeUser.Id].Add(ev.Id);
            }
            else
            {
                List<Guid> ids = new List<Guid>() { ev.Id };
                UserstoEvents.Add(activeUser.Id, ids);
            }

            SaveBase();
        }
        public void ChangeEvent(Guid id, Event ev)
        {
            Events[id] = ev;
            server.UpdateBases();
        }
        public Event GetEventId(Guid id)
        {
            return Events[id];
        }
        public void WriteUserEventsinDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            if (UserstoEvents.ContainsKey(activeUser.Id))
                foreach (var i in UserstoEvents[activeUser.Id])
                {
                    if (Events.ContainsKey(i))
                    {
                        Event ev = Events[i];
                        dgv.Rows.Add(ev.Id, ev.Name, ev.Type, ev.EventLocation, ev.EventData, ev.DataEndRegestration, ev.Organizator, RegesrationStatus(ev.StatusRegestration));
                    }
                    else
                    {
                        UserstoEvents.Remove(i);
                    }
                }
            SaveBase();
        }
        public void WriteAllEventsinDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (var i in Events)
            {
                Event ev = Events[i.Key];
                ev.StatusRegestration = CheckRegestrationStatus(ev.DataEndRegestration);
                dgv.Rows.Add(ev.Id, ev.Name, ev.Type, ev.EventLocation, ev.EventData, ev.DataEndRegestration, ev.Organizator, RegesrationStatus(ev.StatusRegestration));
            }
            SaveBase();
        }
        public void WriteMembers(Event ev, DataGridView dgv)
        {
            foreach (var i in ev.Members)
                dgv.Rows.Add(i.FirstName, i.LastName, i.Email);
        }
        public void SignUpinEvent(Guid id)
        {
            server.DownloadBases();
            Event ev = Events[id];
            if (UserstoEvents.ContainsKey(activeUser.Id))
            {
                if (UserstoEvents[activeUser.Id].Contains(ev.Id))
                {
                    MessageBox.Show("Вы уже зарегестрированы на данное мероприятие", "Ошибка");
                    return;
                }
                else
                {
                    UserstoEvents[activeUser.Id].Add(ev.Id);
                    ev.Members.Add(activeUser.PersonalInfo);
                }
            }
            else
            {
                List<Guid> ids = new List<Guid>() { ev.Id };
                UserstoEvents.Add(activeUser.Id, ids);
            }
            server.UpdateBases();
        }
        public Event NextEvent(Guid id)
        {
            if(!UserstoEvents.ContainsKey(id))
                UserstoEvents.Add(id, new List<Guid>());
            Event next = null;
            foreach (var e in UserstoEvents[id])
            {
                Event et = Events[e];
                if (next.EventData >= et.EventData)
                    next = et;
            }
            return next;

        }
        private bool CheckRegestrationStatus(DateTime regestarationclosedata)
        {
            if (regestarationclosedata <= DateTime.Now)
                return false;
            else
                return true;
        }
        private string RegesrationStatus(bool status)
        {
            if (status)
                return "Открыта";
            else
                return "Закрыта";
        }
    }
    public class Event
    {
        public readonly Guid Id;
        public readonly string Name;
        public readonly string Type;
        public readonly DateTime EventData;
        public readonly DateTime DataEndRegestration;
        public bool StatusRegestration;
        public readonly string Organizator;
        public readonly string EventLocation;
        public readonly string Description;
        public List<PersonalInformation> Members;
        public Event(Guid id, string name, string type, DateTime eventData, DateTime dataEndRegestration, bool statusRegestration, string organizator, string eventLocation, string description)
        {
            Id = id;
            Name = name;
            Type = type;
            EventData = eventData;
            DataEndRegestration = dataEndRegestration;
            StatusRegestration = statusRegestration;
            Organizator = organizator;
            EventLocation = eventLocation;
            Description = description;
            Members = new List<PersonalInformation>();
        }
        public override string ToString()
        {
            return $"{Name} {EventData}";
        }
    }
}


