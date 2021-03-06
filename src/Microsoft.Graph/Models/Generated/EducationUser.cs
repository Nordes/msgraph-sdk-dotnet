// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Education User.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationUser : Entity
    {
    
        /// <summary>
        /// Gets or sets primary role.
        /// Default role for a user. The user's role might be different in an individual class. Possible values are: student, teacher, enum_sentinel. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "primaryRole", Required = Newtonsoft.Json.Required.Default)]
        public EducationUserRole? PrimaryRole { get; set; }
    
        /// <summary>
        /// Gets or sets middle name.
        /// The middle name of user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "middleName", Required = Newtonsoft.Json.Required.Default)]
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Gets or sets external source.
        /// Where this user was created from. Possible values are: sis, manual, unkownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalSource", Required = Newtonsoft.Json.Required.Default)]
        public EducationExternalSource? ExternalSource { get; set; }
    
        /// <summary>
        /// Gets or sets residence address.
        /// Address where user lives.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "residenceAddress", Required = Newtonsoft.Json.Required.Default)]
        public PhysicalAddress ResidenceAddress { get; set; }
    
        /// <summary>
        /// Gets or sets mailing address.
        /// Mail address of user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailingAddress", Required = Newtonsoft.Json.Required.Default)]
        public PhysicalAddress MailingAddress { get; set; }
    
        /// <summary>
        /// Gets or sets student.
        /// If the primary role is student, this block will contain student specific data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "student", Required = Newtonsoft.Json.Required.Default)]
        public EducationStudent Student { get; set; }
    
        /// <summary>
        /// Gets or sets teacher.
        /// If the primary role is teacher, this block will conatin teacher specific data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teacher", Required = Newtonsoft.Json.Required.Default)]
        public EducationTeacher Teacher { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// Entity who created the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets related contacts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "relatedContacts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<EducationRelatedContact> RelatedContacts { get; set; }
    
        /// <summary>
        /// Gets or sets account enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AccountEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets assigned licenses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedLicenses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AssignedLicense> AssignedLicenses { get; set; }
    
        /// <summary>
        /// Gets or sets assigned plans.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedPlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AssignedPlan> AssignedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets business phones.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessPhones", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> BusinessPhones { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "department", Required = Newtonsoft.Json.Required.Default)]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name displayed in the address book for the user. This is usually the combination of the user's first name, middle initial, and last name. This property is required when a user is created and it cannot be cleared during updates. Supports $filter and $orderby.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// The given name (first name) of the user. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "givenName", Required = Newtonsoft.Json.Required.Default)]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets mail.
        /// The SMTP address for the user; for example, "jeff@contoso.onmicrosoft.com". Read-Only. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mail", Required = Newtonsoft.Json.Required.Default)]
        public string Mail { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailNickname", Required = Newtonsoft.Json.Required.Default)]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets mobile phone.
        /// The primary cellular telephone number for the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobilePhone", Required = Newtonsoft.Json.Required.Default)]
        public string MobilePhone { get; set; }
    
        /// <summary>
        /// Gets or sets password policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPolicies", Required = Newtonsoft.Json.Required.Default)]
        public string PasswordPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets password profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordProfile", Required = Newtonsoft.Json.Required.Default)]
        public PasswordProfile PasswordProfile { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "officeLocation", Required = Newtonsoft.Json.Required.Default)]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets preferred language.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferredLanguage", Required = Newtonsoft.Json.Required.Default)]
        public string PreferredLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets provisioned plans.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "provisionedPlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ProvisionedPlan> ProvisionedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets refresh tokens valid from date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refreshTokensValidFromDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RefreshTokensValidFromDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets show in address list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showInAddressList", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowInAddressList { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// The user's surname (family name or last name). Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "surname", Required = Newtonsoft.Json.Required.Default)]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets usage location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usageLocation", Required = Newtonsoft.Json.Required.Default)]
        public string UsageLocation { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets user type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userType", Required = Newtonsoft.Json.Required.Default)]
        public string UserType { get; set; }
    
        /// <summary>
        /// Gets or sets schools.
        /// Schools to which the user belongs. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schools", Required = Newtonsoft.Json.Required.Default)]
        public IEducationUserSchoolsCollectionWithReferencesPage Schools { get; set; }
    
        /// <summary>
        /// Gets or sets classes.
        /// Classes to which the user belongs. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classes", Required = Newtonsoft.Json.Required.Default)]
        public IEducationUserClassesCollectionWithReferencesPage Classes { get; set; }
    
        /// <summary>
        /// Gets or sets user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "user", Required = Newtonsoft.Json.Required.Default)]
        public User User { get; set; }
    
    }
}

