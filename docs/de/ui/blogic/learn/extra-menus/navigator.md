---
uid: help-de-ui-extra-menu-navigator
title: Navigatorgruppe und Zusatzmenü hinzufügen
description: Navigatorgruppe und Zusatzmenü hinzufügen
author: SuperOffice RnD
date: 06.29.2022
keywords: Navigatorgruppe
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Navigatorgruppe und Zusatzmenü hinzufügen

[!include[Legacy](../includes/legacy-extra-menus.md)]

Um diese Funktion zu veranschaulichen, werden wird eine neue Navigatorgruppe im Navigator links in SuperOffice hinzugefügt. Wir werden ein Zusatzmenü in der neuen Navigatorgruppe hinzufügen. In unserem Beispiel werden wir die Navigatorgruppe "Webseiten" mit einigen nützlichen Webseiten hinzufügen.

1. Wählen Sie <i class="ph ph-list" aria-label="Main menu"></i> > **Systemeinstellungen** > **Systemdesign** > **Zusatzmenüs** aus.

2. Zeigen Sie mit dem Mauszeiger auf den Ordner **Navigator** und klicken Sie auf **+**.

3. Geben Sie "Webseiten" in das Feld **Bezeichnung** ein (maximal 14 Zeichen).

4. Optional: Klicken Sie auf die Schaltfläche **Auswählen** rechts neben dem Feld **Symbol-URL**, um ein Symbol für die Navigatorgruppe auszuwählen. Sie können entweder ein Bild wählen, das bereits in der Datenbank vorhanden ist, oder ein Bild hochladen. Das Bild sollte eine Größe von 36x36 Pixeln aufweisen, sodass es im Navigator richtig dargestellt wird. Sie wählen das Bild und ändern die Größe im selben Dialogfeld.

5. Klicken Sie auf **Position**, um zu wählen, wo die neue Navigatorgruppe positioniert werden soll (0 = oben).

6. Klicken Sie auf **OK**. Die neue Navigatorgruppe wird links auf dem Bildschirm angezeigt. Die Navigatorgruppe ist leer, es müssen also Websites hinzugefügt werden. In diesem Fall fügen wir Google hinzu.

7. Zeigen Sie mit dem Mauszeiger auf die Navigatorgruppe, die Sie gerade erstellt haben, und klicken Sie auf **+**. Die Ansicht **Eigenschaften des Menüs** wird geöffnet.

8. Geben Sie "Google" in das Feld **Bezeichnung** ein (maximal 20 Zeichen).

9. Aktivieren Sie die Option **URL verwenden** und geben Sie `http://www.google.com` in das Feld **URL** ein.

10. Aktivieren Sie NICHT **ID anhängen** oder **&lt;usec&gt; anhängen**, damit keine Werte hinter der definierten URL hinzugefügt werden.

11. Aktivieren Sie NICHT **Zur selben Ansicht zurückkehren**. Wenn diese Option aktiviert ist, funktionieren externe URLs nicht. Siehe [Eigenschaften des Menüs][1].

12. Geben Sie im Feld **Ziel** "_blank" ein, damit sich die Webseite in einer neuen Registerkarte im Browser öffnet.

13. Klicken Sie auf **OK**.

14. Klicken Sie auf die Navigatorgruppe und das neue Zusatzmenü und stellen Sie sicher, dass sich die Webseite richtig öffnet.

<!-- Referenced links -->
[1]: properties.md
