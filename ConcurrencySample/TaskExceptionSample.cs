using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencySample
{
    public class TaskExceptionSample
    {
        public void Start()
        {
            // in task we can handle excetion in this place
            try
            {
                Task<int> badMethod = Task.Run(() => BadMethod(null, null));

                Console.WriteLine(badMethod.Result.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
            }
        }

        public int BadMethod(int? num1, int? num2)
        {
            if(num1 == null)
                throw new ArgumentNullException(nameof(num1));  
            if(num2 == null)
                throw new ArgumentNullException(nameof(num2));  
            
            return num1.Value + num2.Value;
        }
    }
}
