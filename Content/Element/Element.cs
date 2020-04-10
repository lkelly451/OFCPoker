using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFCPoker.Content.Element
{
    interface Element
    {
        void Load(in Element element);

        void Update(in Element element);

        void Draw(in Element element);
    }
}
