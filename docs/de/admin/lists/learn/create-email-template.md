---
uid: help-de-mail-link-create-template
title: E-Mail-Vorlagen erstellen
description: E-Mail-Vorlagen erstellen
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail-Link
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# E-Mail-Vorlagen erstellen

Sie können Ihre eigenen Vorlagen erstellen, die Sie beim Erstellen von E-Mails aus SuperOffice CRM verwenden können. Gehen Sie wie folgt vor:

1. Erstellen Sie eine neue E-Mail, zum Beispiel mit Outlook Express. Wenn Sie Standard-Dokumentvorlagenvariablen verwenden, schließen Sie sie wie folgt in Klammern ein: `{name}`.

2. Speichern Sie die Datei im *.oft* Format, aber legen Sie die Erweiterung auf *.somail*fest. Zum Beispiel: *my-mail.somail*.

3. Verschieben Sie die Datei in den Ordner *\\so_arc\\template*.

4. Öffnen Sie Einstellungen und Verwaltung.

5. Öffnen Sie die Ansicht **Listen**.

6. Wählen Sie die Registerkarte **Objekte**.

7. [!include[Click arrow and select](includes/expand-list.md)] Wählen Sie **Dokumentvorlage** von der Dropdown-**Liste** aus.

8. Klicken Sie auf der Schaltfläche **Hinzufügen** unter der Liste.

9. Geben Sie im Dialogfeld den gewünschten Namen für die Vorlage im Pflichtfeld **Name** ein.

10. Klicken Sie im Feld **Dateiname** auf <i class="ph ph-caret-down" aria-label="Chevron"></i> und wählen Sie die Datei *.somail* aus, die Sie gerade erstellt haben.

11. Klicken Sie im Feld **Richtung** auf <i class="ph ph-caret-down" aria-label="Chevron"></i> und wählen Sie vom Dropdown-Menü **Ausgehende** aus.

12. Klicken Sie im Feld **Datensatztyp** auf <i class="ph ph-caret-down" aria-label="Chevron"></i> und wählen Sie **E-Mail** aus.

13. Wählen Sie im Feld **Dokument-Plugin** das Programm aus, mit dem das Dokument angezeigt werden soll. Klicken Sie dazu auf <i class="ph ph-caret-down" aria-label="Chevron"></i> und wählen Sie eine Option im Dropdown aus.

14. Klicken Sie im Feld **Zweck** auf <i class="ph ph-caret-down" aria-label="Chevron"></i> und wählen Sie eine der voreingestellten Optionen vom Dropdown-Menü aus. Diese Objekte gehören zur Statuskontrollfunktion von SuperOffice CRM, für die eine SAINT-Lizenz erforderlich ist.

15. Aktivieren Sie das Feld **Veröffentlichen**, damit ein Benutzer in dem Dialogfeld Dokument auswählen kann, ob die betreffende Dokumentvorlage für externe Benutzer verfügbar sein soll.

16. Geben Sie eine Standardeinstellung in das Feld **Unser Zeichen (Standard)** ein, indem Sie Vorlagenvariablen verwenden, zum Beispiel {auth} für den Vor- und Nachnamen des Absenders.

17. Wählen Sie im Feld **In Datenbank speichern** die Option **Nein** aus.

18. Geben Sie im Feld **Öffnungsschlüssel für Registrierung** *SoMailParser.exe* ein.

19. Geben Sie optional in das Feld **Beschreibung** eine Beschreibung für die E-Mail-Vorlage ein.

20. Klicken Sie auf **OK**. Die Vorlage wird als separates Objekt zur Liste **Objekte** hinzugefügt.

21. Klicken Sie auf **Speichern**.

Mit dieser Vorlage können Sie jetzt neue E-Mails aus SuperOffice CRM erstellen.
