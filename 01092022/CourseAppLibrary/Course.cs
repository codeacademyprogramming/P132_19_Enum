using CourseAppLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseAppLibrary
{
    public class Course
    {
        public List<Group> Groups { get; private set; } = new List<Group>();

        public List<Group> GetGroupsByCategory(GroupType category)
        {
            List<Group> wantedGroups = new List<Group>();

            foreach (var gr in this.Groups)
            {
                if(gr.Category == category)
                    wantedGroups.Add(gr);
            }

            return wantedGroups;
        }

        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }

        public bool HasGroupByNo(string no)
        {
            foreach (var item in Groups)
            {
                if (item.No == no)
                    return true;
            }

            return false;
        }
    }
}
