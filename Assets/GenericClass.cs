using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class User
{
    public int id { get; set; }
    public string name { get; set; }
}

public class GenericClass : MonoBehaviour
{
    List<User> userList = new List<User>();

    private void Start()
    {
        addUesr(1, "����ȣ");
        Debug.Log(userList[0].name);
    }

    void addUesr(int id, string name)
    {
        User user = new User();
        user.id = id;
        user.name = name;
        userList.Add(user);
    }


}

/*public class User
{
    public int id { get; set; }
    public string name { get; set; }
}

public class GenericClass : MonoBehaviour
{
    List<User> userList = new List<User>();

    private void Start()
    {
        addUserList(1, "����ȣ");
        Debug.Log(userList[0].name);
    }

    User addUserList(int id, string name)
    {
        User user = new User();
        user.id = id;
        user.name = name;
        userList.Add(user);
        return user;
    }


}*/


/*public class User
{
    public int id { get; set; }
    public string name { get; set; }
}


public class GenericClass : MonoBehaviour
{

    List<User> userList = new List<User>();
    private void Start()
    {
         userListAdd(1, "khj");
    }

    
    User userListAdd(int id, string name)
    {
        User user = new User();
        user.id = id;
        user.name = name;
        userList.Add(user);
        return user;
    }

}*/


/*    class User
    {
        public int id { get; set; }
        public string name { get; set; }
    }


    // Start is called before the first frame update
    void Start()
    {
        int idValue = 1;
        string nameValue = "����ȣ";

        var userList = new List<User>()
        {
            new User(){id= idValue, name = nameValue }
        };

        Debug.Log(userList[0].id + userList[0].name);

    }*/




/*public class GenericClass : MonoBehaviour
{
    class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        var categories = new List<Category>()
        {
            new Category(){ id = 1, name = "����ȣ"},
            new Category(){ id = 2, name = "������"}

        };

        Debug.Log($"{categories[0].id} {categories[0].name}");

        foreach (var category in categories)
        {
            
        }

    }
}*/
