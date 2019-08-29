using System;
using System.Collections.Generic;

namespace FriendProject {
    class Program {
        static void Main(string[] args) {

            //List<int> integers = new List<int>();
            //integers.Add(17);
            //integers.Add(0);
            //integers.Add(88);
            //integers.Add(43);
            //var count = integers.Count; //how many items are in collection
            //integers.Sort();
            //integers.Remove(0);

            var friend1 = new Friend("Friend1", "555-555-5551", "email1@email.com", true, 9);
            var friend2 = new Friend("Friend2", "555-555-5552", "email2@email.com", false, 8);
            var friend3 = new Friend("Friend3", "555-555-5553", "email3@email.com", false, 7);
            var friend4 = new Friend("Friend4", "555-555-5554", "email4@email.com", true, 6);
            var friend5 = new Friend("Friend5", "555-555-5555", "email5@email.com", true, 5);

            //var friends = new Friend[] { friend1, friend2, friend3, friend4, friend5 };

            var friends = new List<Friend>();
            friends.Add(friend1);
            friends.Add(friend2);
            friends.Add(friend3);
            friends.Add(friend4);
            friends.Add(friend5);

            var aFriend = friends[0];

            foreach (var friend in friends) {
               friend.HowLong = (friend.BFF) ? 10 :0;
                Console.WriteLine(friend/*$"{friend.Name} {friend.Phone} {friend.Email} {friend.BFF} {friend.HowLong + " years"}"*/);
            }
            var StateCodes = new Dictionary<string, string>();
            StateCodes.Add("OH", "Ohio");
            StateCodes.Add("KY", "Kentucky");
            StateCodes.Add("IN", "Indiana");
            var ohio = StateCodes["OH"];

        }

    }
}
