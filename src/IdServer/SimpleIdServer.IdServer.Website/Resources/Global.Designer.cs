﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleIdServer.IdServer.Website.Resources {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Global {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Global() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SimpleIdServer.IdServer.Website.Resources.Global", typeof(Global).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à The client &apos;{0}&apos; has successfully been added.
        /// </summary>
        public static string ClientAdded {
            get {
                return ResourceManager.GetString("ClientAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Client cannot be added because an another client exists with the same name.
        /// </summary>
        public static string ClientAlreadyExists {
            get {
                return ResourceManager.GetString("ClientAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à External authentication provider has been unlinked.
        /// </summary>
        public static string ExternalAuthProviderUnlinked {
            get {
                return ResourceManager.GetString("ExternalAuthProviderUnlinked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Redirection url &apos;{0}&apos; is not valid.
        /// </summary>
        public static string InvalidRedirectUrl {
            get {
                return ResourceManager.GetString("InvalidRedirectUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Redirection url &apos;{0}&apos; cannot contains fragment (#).
        /// </summary>
        public static string RedirectUriContainsFragment {
            get {
                return ResourceManager.GetString("RedirectUriContainsFragment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Resource &apos;{0}&apos; is added.
        /// </summary>
        public static string ResourceAdded {
            get {
                return ResourceManager.GetString("ResourceAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Resource with the name &apos;{0}&apos; already exists.
        /// </summary>
        public static string ResourceAlreadyExists {
            get {
                return ResourceManager.GetString("ResourceAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Resource details have been updated.
        /// </summary>
        public static string ResourceDetailsUpdated {
            get {
                return ResourceManager.GetString("ResourceDetailsUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Selected clients have been removed.
        /// </summary>
        public static string SelectedClientsRemoved {
            get {
                return ResourceManager.GetString("SelectedClientsRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Resource mappers have been removed.
        /// </summary>
        public static string SelectedResourceMappersRemoved {
            get {
                return ResourceManager.GetString("SelectedResourceMappersRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Selected resources have been removed.
        /// </summary>
        public static string SelectedResourcesRemoved {
            get {
                return ResourceManager.GetString("SelectedResourcesRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à The resource &apos;{0}&apos; doesn&apos;t exist.
        /// </summary>
        public static string UnknownResource {
            get {
                return ResourceManager.GetString("UnknownResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à The user &apos;{0}&apos; doesn&apos;t exist.
        /// </summary>
        public static string UnknownUser {
            get {
                return ResourceManager.GetString("UnknownUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à User claims has been updated.
        /// </summary>
        public static string UserClaimsUpdated {
            get {
                return ResourceManager.GetString("UserClaimsUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à User consent has been rejected.
        /// </summary>
        public static string UserConsentRejected {
            get {
                return ResourceManager.GetString("UserConsentRejected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à User credential has been added.
        /// </summary>
        public static string UserCredentialAdded {
            get {
                return ResourceManager.GetString("UserCredentialAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à User credential is removed.
        /// </summary>
        public static string UserCredentialRemoved {
            get {
                return ResourceManager.GetString("UserCredentialRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à User credential is updated.
        /// </summary>
        public static string UserCredentialUpdated {
            get {
                return ResourceManager.GetString("UserCredentialUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à User details have been updated.
        /// </summary>
        public static string UserDetailsUpdated {
            get {
                return ResourceManager.GetString("UserDetailsUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à User session has been rejected.
        /// </summary>
        public static string UserSessionRejected {
            get {
                return ResourceManager.GetString("UserSessionRejected", resourceCulture);
            }
        }
    }
}
