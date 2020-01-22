﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Web.Mvc;

namespace Microsoft.Web.Mvc.ModelBinding
{
    public sealed class ModelValidatedEventArgs : EventArgs
    {
        public ModelValidatedEventArgs(ControllerContext controllerContext, ModelValidationNode parentNode)
        {
            if (controllerContext == null)
            {
                throw new ArgumentNullException("controllerContext");
            }

            ControllerContext = controllerContext;
            ParentNode = parentNode;
        }

        public ControllerContext ControllerContext { get; private set; }

        public ModelValidationNode ParentNode { get; private set; }
    }
}