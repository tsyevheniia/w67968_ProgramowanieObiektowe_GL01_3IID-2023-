namespace lab4_zad2
{
    public class PeselHelper
        
    {
        public static DateTime GetBirthDay(string pesel)
        {
            var year = int.Parse(pesel.Substring(0, 2));
            var month = int.Parse(pesel.Substring(2, 2));
            var day = int.Parse(pesel.Substring(4, 2));

            if (month > 80)
            {
                year = year + 1800;
                month = month - 80;
            }
            else if (month > 60)
            {
                year = year + 2200;
                month = month - 60;
            }
            else if (month > 40)
            {
                year = year + 2100;
                month = month - 40;
            }
            else if (month > 20)
            {
                year = year + 2000;
                month = month - 20;
            }
            else
            {
                year += 1900;
            }

            return new DateTime(year, month, day);
        }
    }
}

