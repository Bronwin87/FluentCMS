﻿namespace FluentCMS;

public class ExceptionCodes
{
    #region Setup

    public const string SetupSettingsNotDefined = "SetupSettings.NotDefined";
    public const string SetupSettingsAlreadyInitialized = "SetupSettings.AlreadyInitialized";
    public const string SetupSettingsTemplatesPathNotDefined = "SetupSettings.TemplatesPathNotDefined";
    public const string SetupSettingsTemplatesFolderNotFound = "SetupSettings.TemplatesFolderNotFound";
    public const string SetupSettingsHostingEnvironmentIsNull = "SetupSettings.HostingEnvironmentIsNull";

    #endregion

    #region GlobalSettings

    public const string GlobalSettingsUnableToUpdate = "GlobalSettings.UnableToUpdate";
    public const string GlobalSettingsUnableToInit = "GlobalSettings.UnableToInit";
    public const string GlobalSettingsAtLeastOneSuperUser = "GlobalSettings.AtLeastOneSuperUser";
    public const string GlobalSettingsUnableToRemoveYourself = "GlobalSettings.UnableToRemoveYourself";
    public const string GlobalSettingsNotFound = "GlobalSettings.NotFound";

    #endregion

    #region User

    public const string UserNotFound = "User.NotFound";
    public const string UserLoginFailed = "User.LoginFailed";
    public const string UserChangePasswordFailed = "User.ChangePasswordFailed";
    public const string UserTokenGenerationFailed = "User.TokenGenerationFailed";

    #endregion

    #region App

    public const string AppNotFound = "App.NotFound";
    public const string AppSlugNotUnique = "App.SlugNotUnique";
    public const string AppUnableToCreate = "App.UnableToCreated";
    public const string AppUnableToUpdate = "App.UnableToUpdate";
    public const string AppUnableToDelete = "App.UnableToDelete";

    #endregion

    #region AppTemplate

    public const string AppTemplateNotFound = "AppTemplate.NotFound";
    public const string AppTemplateUnableToCreate = "AppTemplate.UnableToCreated";

    #endregion

    #region Role


    public const string RoleUnableToCreate = "Role.UnableToCreated";
    public const string RoleUnableToUpdate = "Role.UnableToUpdate";
    public const string RoleUnableToDelete = "Role.UnableToDelete";
    public const string RoleNotFound = "Role.NotFound";
    public const string RoleNameMustBeUnique = "Role.NameMustBeUnique";
    public const string RoleInvalidAppId = "Role.InvalidAppId";

    #endregion

    #region Content
    public const string ContentUnableToCreate = "Content.UnableToCreated";
    public const string ContentUnableToUpdate = "Content.UnableToUpdate";
    public const string ContentUnableToDelete = "Content.UnableToDelete";
    public const string ContentNotFound = "Content.NotFound";
    public const string ContentTypeMismatch = "Content.TypeMismatch";
    public const string ContentAppIdMismatch = "Content.AppIdMismatch";
    #endregion

    #region ContentType

    public const string ContentTypeUnableToCreate = "ContentType.UnableToCreated";
    public const string ContentTypeUnableToUpdate = "ContentType.UnableToUpdate";
    public const string ContentTypeUnableToDelete = "ContentType.UnableToDelete";
    public const string ContentTypeNotFound = "ContentType.NotFound";
    public const string ContentTypeNameCannotBeChanged = "ContentType.NameCannotBeChanged";
    public const string ContentTypeNameMustBeUnique = "ContentType.NameMustBeUnique";
    public const string ContentTypeFieldNotFound = "ContentType.FieldNotFound";
    public const string ContentTypeInvalidAppId = "ContentType.ContentTypeInvalidAppId";

    #endregion

    #region Plugin

    public const string PluginUnableToCreate = "Plugin.UnableToCreated";
    public const string PluginUnableToUpdate = "Plugin.UnableToUpdate";
    public const string PluginUnableToDelete = "Plugin.UnableToDelete";
    public const string PluginNotFound = "Plugin.NotFound";

    #endregion

    #region PluginDefinition

    public const string PluginDefinitionUnableToCreate = "PluginDefinition.UnableToCreated";
    public const string PluginDefinitionUnableToUpdate = "PluginDefinition.UnableToUpdate";
    public const string PluginDefinitionUnableToDelete = "PluginDefinition.UnableToDelete";
    public const string PluginDefinitionNotFound = "PluginDefinition.NotFound";

    #endregion

    #region Layout

    public const string LayoutUnableToCreate = "Layout.UnableToCreated";
    public const string LayoutUnableToUpdate = "Layout.UnableToUpdate";
    public const string LayoutUnableToDelete = "Layout.UnableToDelete";
    public const string LayoutNotFound = "Layout.NotFound";

    #endregion

    #region Site

    public const string SiteNotFound = "Site.NotFound";
    public const string SiteUrlMustBeUnique = "Site.UrlMustBeUnique";
    public const string SiteUnableToCreate = "Site.UnableToCreated";
    public const string SiteUnableToUpdate = "Site.UnableToUpdate";
    public const string SiteUnableToDelete = "Site.UnableToDelete";

    #endregion

    #region Page

    public const string PageUnableToCreate = "Page.UnableToCreated";
    public const string PageUnableToUpdate = "Page.UnableToUpdate";
    public const string PageUnableToDelete = "Page.UnableToDelete";
    public const string PagePathMustBeUnique = "Page.PathMustBeUnique";
    public const string PageNotFound = "Page.NotFound";
    public const string PageParentPageNotFound = "Page.ParentPageNotFound";
    public const string PageParentMustBeOnTheSameSite = "Page.ParentMustBeOnTheSameSite";
    public const string PageViewPermissionsAreNotASubsetOfParent = "Page.ViewPermissionsAreNotASubsetOfParent";
    public const string PageSiteIdCannotBeChanged = "Page.SiteIdCannotBeChanged";
    public const string PageHasChildren = "Page.PageHasChildren";

    #endregion
}
