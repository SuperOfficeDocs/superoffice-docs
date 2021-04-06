---
uid: crmscript_ref_User_setValue_String_column_String_Value
title: User.setValue(String column, String Value)
intellisense: User.setValue
keywords: setValue(String,String)
so.topic: reference
---

Sets a value in a given column.



###Parameters:###


 - String with column name
 - String with value to set




###Possible values:###


 - id: Integer, The primary key (auto-incremented)
 - loginname: String, The unique loginname for this user.
 - username: String, The unique username for this user.
 - password: String, The encrypted password for this user.
 - firstname: String, The firstname for this user.
 - middlename: String, The middlename for this user.
 - lastname: String, The lastname for this user.
 - email: String, The email address for this user.
 - status: Integer, The status (enum) for this user. 1 is Active, 2 is Not Present, 3 is deleted
 - signature: String, The users signature.
 - notifyMask: Integer, A bitmask indicating to which extent the user should recieve pop-up warnings for various events.
 - emailMask: Integer, A bitmask indicated to which extent the user should recieve email warnings for various events.
 - smsMask: Integer, A bitmask indicated to which extent the user should recieve sms warnings for various events.
 - language: String, A string indicating the user's language ("no" or "en").
 - pageLength: Integer, The user's preferred page length when listing tickets.
 - textareasize: Sttring, Size of textarea for each user, example "80x40"
 - flags: Integer, A bitmask indicating flags for this entry.
 - lastCategory: Integer, The last chosen category for this user when posting tickets. category.id
 - profileId: Integer, Reference to the profile connected to this ejuser profile.id
 - hiddenBagBitset: String, Each character represent a bit to set a HtmlBagHideable to default open or closed (1=open 0=closed)
 - defaultListTickets: Integer, The user can choose which criteria\_set should be the default. Stored here. criteria\_set.id
 - notifyExternalLock: DateTime, A datetime lock to make sure notifications are only displayed by one notifcation system (ejournal or external programs)
 - notifyExternalSource: Integer, A name (id) of the external notifications system (ejournal or external programs)
 - loginAttempts: Integer, The number of times the user has attempted to login with the wrong password
 - lastLoginAttempt: DateTime, The last time the user tried to log in without success
 - idleTime: Integer, Number of seconds the user has been idle. Updated by TrayIcon or simular external programs.
 - defaultUser: Integer, The default user to set on new tickets in this category (1=automatically, 2=unasigned, 3=the owner
 - initials: String, Obsolete field, cannot be removed because of not null error on older systems
 - sms: String, The SMS number for this user
 - pictureId: Integer, The attachment id of the picture for this user.
 - ownerCompany: Integer, the contact id of the owning company of the users' connected person entity.
 - group: Integer, the primary group for this user.
 - role: Integer, the role for this user.
 - x_* The extrafield with the given database field name.


The different notify masks: (Indicated by bit enums)
NewTicket                      = 1,
NewTicketMessage      = 2,
TicketEscalated             = 3,
TicketActivated             = 4,

    ActiveTickets                 = 5, // only used as a filter (ejuser)
    TicketTakeOver             = 6,
    Hotlist                             = 9,  // only used as a filter (ejuser)
    Custom                           = 10
    



###The different access flags:###
    AccessNone                   = 0 (value 0),
    AccessListOthers             = 0 (bit number 1),
    AccessReadOthers             = 1,
    AccessEditOthers             = 2,
    AccessEditOwnPref            = 3,
    AccessCategoryAdministration = 4,
    AccessUserAdministration     = 5,
    AccessEjournalAdministration = 6,
    AccessStatistics             = 7,
    AccessDocuments              = 8,

        AccessJustCategory           = 9, // obsolete
        AccessEditProfile            = 10,
        AccessListOnlyOwn            = 11,
        AccessReadOnlyOwn            = 12,
        AccessEditOnlyOwn            = 13,
        AccessChat                   = 14,
        AccessChatAdmin              = 15,
        AccessSpm                    = 16,
        AccessEditFaq                = 17,
        AccessFaqAdmin               = 18,
        AccessListExtraTablesContent = 19,
        AccessEditExtraTablesContent = 20,
        AccessReadSelections         = 21,
        AccessEditSelections         = 22,
        AccessPostToFacebook         = 23,
    
    



###The User flags:###
None                            = 0,
    UseLastCategory                 = 1,
    DefaultTicketClose              = 2,
    DefaultMessageClose             = 3,
    SortDesc                        = 4,
    PreviewImages                   = 5,
    OnlyOwnCategories               = 6,
    SmallFonts                      = 7,
    InsertLastMessage               = 8,
    ShowQuickSearch                 = 9,
    Use24HrsClock                   = 10,
    AddMessageNewWindow             = 11,
    OnlyShowOpenTicketsInHotlist    = 12,
    UseLocalClock                   = 13,
    HighlightActiveScreenElement    = 14,
    DisplayOwnCategories            = 15,
    SuppressWarnOnNavigate          = 16,
    SuppressPreviewWarning          = 17,
    PlainTextEditor                 = 18,
    FckEditorSingleLineBreak        = 19,
    CustomDateFormat                = 20,
    SundayFirstDayInWeek            = 21,
    OldScreensOnEditTicket          = 22,
    KeepFormattingOnPaste           = 23,
    DisplayCheckboxLeft             = 24,
    ShowMessagesAsPlainText         = 25,


