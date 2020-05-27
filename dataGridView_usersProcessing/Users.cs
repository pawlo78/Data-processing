using System.Collections.Generic;


namespace dataGridView_usersProcessing
{
    public class Users
    {
        List<Users> usersList;

        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string level { get; set; }

        //constructor
        public Users(int id, string name, string surname, string level)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.level = level;
        }

        public Users() { }

        //create List users
        public List<Users> InitializeDataUsers()
        {
            usersList = new List<Users>();
            usersList.Add(new Users(1, "Tom", "Street", "Expert"));
            usersList.Add(new Users(2, "Paul", "Car", "Beginner"));
            usersList.Add(new Users(3, "Sonia", "Mirror", "Average"));
            usersList.Add(new Users(4, "Tom", "Horse", "Expert"));
            usersList.Add(new Users(5, "Michael", "Elbow", "Average"));
            usersList.Add(new Users(6, "Sandra", "Mirror", "Beginner"));
            return usersList;
        }

        //delete user
        public List<Users> DeleteUser(int index)
        {
            //delete selected row
            usersList.RemoveAt(index);           
            return usersList;
        }

        //adding user and next list item
        public List<Users> AddUser(int lastId, string name, string surname, string level)
        {
            usersList.Add(new Users(lastId, name, surname, level));
            return usersList;
        }   
        
        //Modify user
        public List<Users> EditUser(int selectedId, string name, string surname, string level)
        {
            //id selected
            id = selectedId;
            //index of the selected row
            int index = usersList.FindIndex(item => item.id == id);
            //data assignment
            this.name = name;
            this.surname = surname;
            this.level = level;
            //data overwriting
            usersList[index] = new Users(id, name, surname, level);
            return usersList;
        }
    }
}
