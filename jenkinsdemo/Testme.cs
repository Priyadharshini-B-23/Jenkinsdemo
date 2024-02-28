namespace jenkinsdemo
{
    public class Testme
    {
        public String sayJenkins(int times)
        {
            String output = "";
            for (int i = 0; i < times; i++) 
            {
            output+="Jenkins";
            }
            return output;
        }
    }
}
