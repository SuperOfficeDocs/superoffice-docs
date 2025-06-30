<!-- markdownlint-disable-file MD041 -->
Der erste Schritt beim Erstellen einer E-Mail-Kampagne wird als **Setup** bezeichnet. Hier können Sie Informationen zur E-Mail-Kopfzeile einstellen, z. B. Absender, Antwort an und Betreff. Darüber hinaus können Sie Anlagen und Archivierungsoptionen für die Kampagne hinzufügen und Überwachungsoptionen wählen.

1. Geben Sie einen Namen im Feld **Name der Kampagne** ein.

1. Geben Sie den Betreff der E-Mail im Feld **E-Mail-Betreff** ein.

1. Wählen Sie in der Liste **Von** **Immer verwenden** und geben Sie die E-Mail-Adresse des Absenders in das darunter liegende Feld ein, um für alle Kampagnen den gleichen Absender zu verwenden. Sie können auch einen Vertriebs-Ansprechpartner oder einen Verantwortlichen für den Benutzersupport als Absender angeben, falls einer für diesen Empfänger festgelegt ist. Geben Sie die E-Mail-Adresse ein, die verwendet werden soll, wenn keine für Vertrieb oder Benutzersupport verantwortliche Person verfügbar ist. Wenn Ihr Administrator die [globale E-Mail-Validierungseinstellung][2] aktiviert hat, müssen Sie in der Dropdown-Liste die Domäne auswählen, von der Sie senden möchten.

    [!include[Note](spf-look-up.md)]

1. In der Liste **Antwort an** haben Sie die gleichen Optionen wie oben. Zusätzlich dazu können Sie **"Von" als Antwortadresse verwenden** auswählen. Sämtliche Antworten werden dann an den Absender gesendet.

1. Wählen Sie einen **Order** aus, in dem Sie die Kampagne platzieren wollen.

    [Wie man einen Kampagnen-Ordner erstellt][4]

1. In den Feldern **Selektion** und **Projekt** können Sie die Kampagne einer Selektion und/oder einem Projekt zuordnen. Wenn Sie eine Selektion hinzufügen, werden alle Personen aus der Selektion als Empfänger zur Kampagne hinzugefügt.

    [!include[Start typing to search](type-to-search.md)]

1. Wählen Sie in der Liste **Typ** den Typ der Kampagne aus, die Sie erstellen. Wählen Sie **(Beliebig)**, wenn die Kampagne zwei oder mehr der verfügbaren Typen entspricht. Verwenden Sie **Alle**, nachdem Sie mehrere Empfänger mit mehreren Abonnements hinzugefügt haben und die Kampagne an alle gesendet werden soll.

1. **Anlagen**: Wählen Sie eine der folgenden Methoden, um der Kampagne eine oder mehrere Anlagen hinzuzufügen:

    * Klicken Sie auf **Dateien hochladen (oder hierhin ziehen und ablegen)**, um eine Datei auf einer Festplatte oder einem Server zu suchen und hinzuzufügen.
    * Ziehen Sie das Dokument aus dem Windows Explorer in das Feld Anlagen und legen Sie es dort ab.
    * Klicken Sie auf **Ein CRM-Dokument auswählen**, um ein Dokument in SuperOffice CRM auszuwählen.

1. Unter **Überwachen** finden Sie die folgenden Optionen:

    [!include[Tracking options for mailing](mailing-tracking-options.md)]

1. Klicken Sie auf **Weiter**, um zum nächsten Schritt zu gelangen.

### E-Mail-Domäne-Validierung (NUR ONLINE)

Wenn Ihr Administrator die [globale Einstellung][2] **Nur genehmigte E-Mail-Domänen verwenden** aktiviert hat, wird das Feld **Von Adresse** aufgeteilt, und Sie müssen die Domäne, von der Sie senden möchten, in der Dropdown-Liste der genehmigten Domänen auswählen.
Wenn Sie versuchen, von einer Domain zu senden, die keinen gültigen SPF-Eintrag hat, wird eine Warnung ausgegeben und die Sendung von dieser Domäne ist nicht möglich. Dies gilt für alle E-Mail-Domäne, auch wenn die Validierungseinstellung nicht aktiviert ist.

> [!NOTE]
> Wenn die **Unsere Kontaktadresse**eine nicht validierte E-Mail-Domäne hat, wird die Kampagne automatisch von der Adresse gesendet, die in den Optionen der Dropdown-Liste **Andernfalls verwenden** angegeben ist.

<!-- Referenced links -->
[2]: ../../../../../admin/lists/learn/add-items-to-mailing-domain.md
[4]: ../../../../learn/create-folder.md

<!-- Referenced images -->
