using System;
using System.Collections.Generic;
using System.Text;

namespace LabRob10
{
    
        abstract class Guarantee
        {
            public abstract int GetGuarantee();
            public abstract void SetGuarantee(int guarantee);
            public void MaxGuarantee()
            {
                Console.WriteLine("Максимальная гарантия - 3 года, при цене >4000");
            }
        }
    
}
