﻿//**********************
//SwEx.PMPage - data driven framework for SOLIDWORKS Property Manager Pages
//Copyright(C) 2019 www.codestack.net
//License: https://github.com/codestackdev/swex-pmpage/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/pmp/
//**********************

using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.PageElements;

namespace CodeStack.SwEx.PMPage.Controls
{
    internal abstract class PropertyManagerPageGroupBaseEx<THandler> : Group
        where THandler : PropertyManagerPageHandlerEx, new()
    {
        public ISldWorks App { get; private set; }
        public THandler Handler { get; private set; }

        internal PropertyManagerPagePageEx<THandler> ParentPage { get; private set; }

        internal PropertyManagerPageGroupBaseEx(int id, object tag, THandler handler,
            ISldWorks app, PropertyManagerPagePageEx<THandler> parentPage) : base(id, tag)
        {
            Handler = handler;
            App = app;
            ParentPage = parentPage;
        }
    }
}