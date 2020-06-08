namespace OverloadOperator
{
    public class Employee
    {
        public int Id { get; set; }

        public static bool operator== (Employee x, Employee y)
        {
            bool results;
            if (x.Id == y.Id)
            {
                results = true;
            }
            else
            {
                results = false;
            }
            return results;
        }

        public static bool operator!= (Employee x, Employee y)
        {
            bool results;
            if (x.Id == y.Id)
            {
                results = false;
            }
            else
            {
                results = true;

            }
            return results;
        }




    }


}

