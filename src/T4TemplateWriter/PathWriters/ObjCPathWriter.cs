// Copyright (c) Microsoft Open Technologies, Inc. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the source repository root for license information.﻿

namespace Vipr.T4TemplateWriter.Output
{
    using System;
    using System.IO;
    using Vipr.T4TemplateWriter.Settings;
    using Vipr.T4TemplateWriter.TemplateProcessor;
    using Vipr.Core.CodeModel;

    class ObjCPathWriter : PathWriterBase
    {

        public override string WritePath(ITemplateInfo template, string entityTypeName)
        {
            string prefix = ConfigurationService.Settings.NamespacePrefix;
            string coreFileName = this.TransformFileName(template, entityTypeName);

            return Path.Combine(
                template.OutputParentDirectory, 
                String.Format("{0}{1}",
                    prefix,
                    coreFileName
                )
            );
        }

    }
}
