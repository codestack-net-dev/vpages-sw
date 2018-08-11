﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.PageElements;

namespace CodeStack.VPages.Sw.Controls
{
    public class PropertyManagerPageGroup<THandler> : Group
        where THandler : PropertyManagerPageHandler, new()
    {
        public SolidWorks.Interop.sldworks.IPropertyManagerPageGroup Group { get; private set; }
        public SolidWorks.Interop.sldworks.ISldWorks App { get; private set; }
        public THandler Handler { get; private set; }

        internal PropertyManagerPageGroup(int id, THandler handler,
            SolidWorks.Interop.sldworks.IPropertyManagerPageGroup group,
            SolidWorks.Interop.sldworks.ISldWorks app) : base(id)
        {
            Group = group;
            Handler = handler;
            App = app;
        }
    }
}
