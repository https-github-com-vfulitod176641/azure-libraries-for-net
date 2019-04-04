// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of a backup which will be performed.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackupRequestInner : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the BackupRequestInner class.
        /// </summary>
        public BackupRequestInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupRequestInner class.
        /// </summary>
        /// <param name="storageAccountUrl">SAS URL to the container.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="backupName">Name of the backup.</param>
        /// <param name="enabled">True if the backup schedule is enabled (must
        /// be included in that case), false if the backup schedule should be
        /// disabled.</param>
        /// <param name="backupSchedule">Schedule for the backup if it is
        /// executed periodically.</param>
        /// <param name="databases">Databases included in the backup.</param>
        public BackupRequestInner(string storageAccountUrl, string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string backupName = default(string), bool? enabled = default(bool?), BackupSchedule backupSchedule = default(BackupSchedule), IList<DatabaseBackupSetting> databases = default(IList<DatabaseBackupSetting>))
            : base(id, name, type, kind)
        {
            BackupName = backupName;
            Enabled = enabled;
            StorageAccountUrl = storageAccountUrl;
            BackupSchedule = backupSchedule;
            Databases = databases;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupName")]
        public string BackupName { get; set; }

        /// <summary>
        /// Gets or sets true if the backup schedule is enabled (must be
        /// included in that case), false if the backup schedule should be
        /// disabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets SAS URL to the container.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountUrl")]
        public string StorageAccountUrl { get; set; }

        /// <summary>
        /// Gets or sets schedule for the backup if it is executed
        /// periodically.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupSchedule")]
        public BackupSchedule BackupSchedule { get; set; }

        /// <summary>
        /// Gets or sets databases included in the backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databases")]
        public IList<DatabaseBackupSetting> Databases { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccountUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountUrl");
            }
            if (BackupSchedule != null)
            {
                BackupSchedule.Validate();
            }
            if (Databases != null)
            {
                foreach (var element in Databases)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
