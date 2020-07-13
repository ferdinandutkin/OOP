namespace SinglyLinkedList
{

    public partial class MyList<T>
    {

        public class Date
        {
            private ushort day, month;
            public ushort Day
            {
                get => day;
                set
                {
                    if (value > 31)
                    {
                        day = 31;
                    }
                    else
                    {
                        day = value;
                    }
                }
            }
            public ushort Month
            {
                get => month;
                set
                {
                    if (value > 12)
                    {
                        month = 12;
                    }
                    else
                    {
                        month = value;
                    }
                }
            }
            public int Year { get; set; }


            public Date(string date)
            {
                string[] tokens = date.Split('.');
                Day = ushort.Parse(tokens[0]);
                Month = ushort.Parse(tokens[1]);
                Year = int.Parse(tokens[2]);
            }

            public Date(ushort day, ushort month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }


            public override string ToString()
            {
                return $"{Day}.{Month}.{Year}";
            }
        }
        public class Owner
        {
            public string GithubID { get; private set; }
            public string Name { get; private set; }
            public string Organization { get; private set; }
            public Owner(string id, string name, string organisation)
            {

                GithubID = id;// "61806555";
                Name = name;// "Tumash Stanislav";
                Organization = organisation;// "BSTU";
            }

            public override string ToString()
            {
                return $"ID: {GithubID}, Имя: {Name}, Организация: {Organization}";
            }

        }
    }


}


