﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Service
{
    public class EventsBase
    {
        private User activeUser { get; }
        public static Dictionary<Guid, Event> Events;
        public static Dictionary<Guid, List<Guid>> UserstoEvents;
        public static List<Guid> UserEvents = new List<Guid>();
        static string pathtobaseevents = "data/bases/events.json";
        static string pathtobasuseridtoeventsid = "data/bases/usertoevents.json";

        public EventsBase()
        {

        }
        public EventsBase(User activeuser)
        {
            activeUser = activeuser;
            ReadEvents();
        }

        private void SaveBase()
        {
            StreamWriter write = new StreamWriter(pathtobaseevents, false);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            serializer.Serialize(write, Events);
            write.Close();
            StreamWriter writer = new StreamWriter(pathtobasuseridtoeventsid, false);
            serializer.Serialize(writer, UserstoEvents);
            writer.Close();
        }
        private void ReadEvents()
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
        public void AddNewEvent(Event ev)
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
        }
        public Event SearchEvent(Guid id)
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
        public void WriteMembers(Event ev,DataGridView dgv)
        {
            if (ev.Members.Count == 0)
                MessageBox.Show("На ваше мероприятие еще никто не записан");
            else
            {
                foreach (var i in ev.Members)
                    dgv.Rows.Add(i.FirstName, i.LastName, i.Email);
            }
        }
        public void SignUpinEvent(Guid id)
        {

            Event ev = Events[id];
            if (UserstoEvents.ContainsKey(activeUser.Id))
            {
                if (UserstoEvents[activeUser.Id].Contains(ev.Id))
                {
                    MessageBox.Show("Вы уже зарегестрированы на данное мероприятие", "Ошибка");
                    return;
                }
                else
                    UserstoEvents[activeUser.Id].Add(ev.Id);
            }
            else
            {
                List<Guid> ids = new List<Guid>() { ev.Id };
                UserstoEvents.Add(activeUser.Id, ids);
            }
            if(ev.Members == null) 
                ev.Members = new List<PersonalInformation> { activeUser.PersonalInfo };
            else 
                ev.Members.Add(activeUser.PersonalInfo);
            UserEvents.Add(id);

        }
        private bool CheckRegestrationStatus(DateTime regestarationclosedata)
        {
            if(regestarationclosedata <= DateTime.Now) 
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
        public Event(Guid id, string name, string type, DateTime eventData, DateTime dataEndRegestration, bool statusRegestration, string organizator, string eventLocation, string description, List<PersonalInformation> members)
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
            Members = members;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime EventData { get; set; }
        public DateTime DataEndRegestration { get; set; }
        public bool StatusRegestration { get; set; }
        public string Organizator { get; set; }
        public string EventLocation { get; set; }
        public string Description { get; set; }
        public List<PersonalInformation> Members { get; set; }
    }
}

