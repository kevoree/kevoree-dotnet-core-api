using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Kevoree.Core.Api
{
    public interface IModelTraceMarshalled
    {
        string getRefName();
        string getSrcPath();
        org.kevoree.pmodeling.api.util.ActionType getTraceType();
        string toCString(bool b1, bool b2);
        string toString();
        bool isOfType(Type a);
        IModelAddTraceMarshalled getModelAddTrace();
        IModelRemoveTraceMarshalled getModelRemoveTrace();
        IModelSetTraceMarshalled getModelSetTrace();
    }
}
