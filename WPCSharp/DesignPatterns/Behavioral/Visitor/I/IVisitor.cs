using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Visitor.I
{
    public interface IVisitor
    {
        void Visit(PlainText plainText);
        void Visit(Hyperlink hyperlink);
        void Visit(BoldText boldText);
    }
}
