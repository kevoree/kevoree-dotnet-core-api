﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Kevoree.Core.Api.IMarshalled
{
    public interface ITypeDefinitionMarshalled
    {
        string getVersion();
        string getName();
        IDictionaryTypeMarshalled getDictionaryType();
        bool isOfType(Type t);

        List<IDeployUnitMarshalled> getDeployUnits();
    }
}
