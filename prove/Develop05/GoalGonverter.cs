// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;
// using System;

// public class PersonConverter : JsonConverter
// {
//     public override bool CanConvert(Type objectType)
//     {
//         return (objectType == typeof(Person));
//     }

//     public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
//     {
//         JObject jo = JObject.Load(reader);

//         string occupation = jo["occupation"]?.ToString();
//         Person person;

//         switch (occupation)
//         {
//             case "Student":
//                 person = new Student(
//                     jo["name"]?.ToString(),
//                     (int)jo["age"],
//                     jo["school"]?.ToString()
//                 );
//                 break;
//             case "Teacher":
//                 person = new Teacher(
//                     jo["name"]?.ToString(),
//                     (int)jo["age"],
//                     jo["school"]?.ToString()
//                 );
//                 break;
//             default:
//                 throw new Exception("Unknown occupation type.");
//         }

//         serializer.Populate(jo.CreateReader(), person);
//         return person;
//     }

//     public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
//     {
//         JObject jo = new JObject();
//         var person = value as Person;
//         if (person != null)
//         {
//             jo.Add("name", person.GetName());
//             jo.Add("age", person.GetAge());

//             if (value is Student student)
//             {
//                 jo.Add("occupation", "Student");
//                 jo.Add("school", student.GetEmployer());
//             }
//             else if (value is Teacher teacher)
//             {
//                 jo.Add("occupation", "Teacher");
//                 jo.Add("school", teacher.GetEmployer());
//             }
//         }
//         jo.WriteTo(writer);
//     }
// }
