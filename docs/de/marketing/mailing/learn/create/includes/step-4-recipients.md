<!-- markdownlint-disable-file MD041 MD034-->
Wenn Sie eine Kampagne erstellen, müssen Sie die Empfänger der Kampagne auswählen. Sie können Empfänger aus mehreren Quellen hinzufügen. Zusätzlich dazu können Sie hier verschiedene Optionen für die Kampagne einstellen und sich eine Vorschau der Kampagne anzeigen lassen.

Ihre Zielliste ist die Gruppe von Personen, von denen Sie glauben, dass sie am besten auf Ihre Mitteilung reagieren werden. Wenn Sie Ihre Marketingmitteilung speziell auf diese Gruppe zuschneiden, haben Sie bessere Erfolgschancen und vermeiden, Zeit und Mühe mit Personen zu verschwenden, die kein Interesse haben.

Sie können Selektionen, Projekte verwenden oder einzelne Personen in SuperOffice CRM hinzufügen.

Aufgrund des DSGVO-Gesetzes können nur die Personen, die ihre Zustimmung zur rechtmäßigen Speicherung in der SuperOffice CRM-Datenbank und zum Erhalt von Informationen erteilt haben, als Empfänger hinzugefügt werden.

![Sie können Ihre Empfänger entweder aus der Auswahl, dem Projekt, einer einzelnen Person oder einer externen Liste hinzufügen, die Sie importieren müssen -screenshot][img3]

## Empfänger aus Selektionen oder Projekten hinzufügen

Sie können Empfänger aus Selektionen (SuperOffice CRM und SuperOffice Service) sowie Projekten (aus SuperOffice CRM) hinzufügen.

1. Klicken Sie unter **Empfänger hinzufügen** auf **Selektion** oder **Projekt**.

2. Klicken Sie auf das Feld unten und geben die ersten Zeichen des Namens der Selektion oder Projektes ein, das hinzugefügt werden soll. Während der Eingabe werden in einer dynamischen Liste die Übereinstimmungen angezeigt.

3. Klicken Sie auf eine Selektion oder ein Projekt in der Liste.

4. Klicken Sie auf **+**. Die Selektion oder das Projekt wird zur Liste **Empfängerquellen** hinzugefügt und die Liste **Empfänger** wird aktualisiert.

5. Wiederholen Sie die Schritte 1-4, um weitere Selektionen oder Projekte hinzuzufügen.

> [!NOTE]
> Wenn Sie in **Setup** (Schritt 1) unter **Kampagne archivieren** eine Selektion ausgewählt haben, wird diese Selektion unter **Empfängerquellen** aufgelistet. Sie können diese Selektion gegebenenfalls löschen.

## Personen aus SuperOffice hinzufügen

Sie können einzelne Personen aus SuperOffice hinzufügen.

1. Klicken Sie unter **Empfänger hinzufügen** auf **Person**.

2. Klicken Sie auf das Feld unten und geben Sie die ersten Zeichen des Namens der Person ein, die hinzugefügt werden soll. Sie können auch einen Firmennamen eingeben, um alle Personen dieser Firma anzuzeigen.

3. Wählen Sie die gewünschte Person aus der angezeigten Liste aus.

4. Klicken Sie auf **+**. Die Person wird zur Liste **Empfängerquellen** hinzugefügt. Die Liste **Empfänger** wird aktualisiert.

5. Gehen Sie wie in Schritt 2 bis 5 erläutert vor, um weitere Personen hinzuzufügen. Zusätzliche Personen werden zur gleichen Zeile in der Liste **Empfängerquellen** hinzugefügt. Die Personenanzahl wird in der Spalte **Name** angezeigt.

## Eine Empfängerliste (Personen) aus einer externen Datei importieren

Sie können Empfänger einer Kampagne hinzufügen, indem Sie sie aus einer externen, durch Komma getrennten Datei importieren (z. B. aus einer in Notepad erstellten .txt-Datei oder einer in Excel erstellen .csv-Datei).

Wenn Sie eine Liste mit Namen und E-Mail-Adressen importieren, versucht SuperOffice Marketing, die importierten Empfänger in der SuperOffice-Datenbank zu finden. Wenn Übereinstimmungen gefunden werden, werden die Firmen der Empfänger in der Liste **Empfänger** in der Spalte **Firma** aufgelistet. Alle Namen oder E-Mail-Adressen, die in SuperOffice **nicht** gefunden werden, werden herausgefiltert und nicht in die Kampagne aufgenommen. Dies liegt an den DSGVO-Vorschriften.

### Schritte

1. Klicken Sie auf **Datei auswählen**.

2. Speicherort der entsprechenden Datei (.txt, .csv oder ähnliches Format) angeben.

3. Klicken Sie auf **+**. Die Liste wird zur Liste **Empfängerquellen** hinzugefügt. Die Liste **Empfänger** wird aktualisiert.

4. Wiederholen Sie die Schritte 2 bis 4, um weitere Empfänger hinzuzufügen. Zusätzliche Empfänger werden zur gleichen Zeile in der Liste **Empfängerquellen** hinzugefügt. Die Gesamtanzahl der Empfänger wird in der Spalte **Name** angezeigt.

> [!NOTE]
> Import ist nicht für Dokumentenkampagnen verfügbar.

### Dateiformat importieren

* Jeder Empfänger steht in einer eigenen Zeile.

* Jeder Empfänger (Zeile) besteht aus dem vollständigen Namen und der E-Mail-Adresse.

    Beispiel: "John Smith, john@company.com"

    > [!NOTE]
    > Außerdem können Sie auch nur die E-Mail-Adresse angeben. Dann ist der Name jedoch nicht als Vorlagenvariable verfügbar.

* Vor Ort: Jeder Empfänger (Zeile) kann auch eine Mobilfunknummer beinhalten (hinter der E-Mail-Adresse), wenn Sie SMS-Kampagnen erstellen. Zum Beispiel: "John Smith, john@company.com, 99999999". Erfordert die Marketing-SMS-Lizenz.

> [!NOTE]
> Wenn Sie nur die Mobilfunknummer haben und eine SMS senden möchten, können Sie Folgendes eingeben: " , , 99887766".

## Empfängeroptionen

Unter **Optionen** im unteren Teil der Ansicht **Empfänger** können Sie je nach dem Typ Optionen für die Kampagne auswählen.

**Verfügbarkeit für Mailing-Kampagne:**

| Option | Dokument | E-Mail | SMS |
|---|:-:|:-:|:-:|
| Einwilligung und Abonnement ignorieren | x | x | x |
| Nur eine Mitteilung pro E-Mail-Adresse | | x | x |
| Empfängerliste beim Senden aktualisieren | | x | x |
| Firmen einbeziehen | x | x | |
| Firma bevorzugen | x | x | |

* **Einwilligung und Abonnement ignorieren**: Wählen Sie diese Option, um die Kampagne auch an Personen zu senden, die keine Einwilligung zum Empfangen von E-Marketing gegeben oder diesen Kampagnentyp nicht abonniert haben. Diese Personen werden mit dem Status **Keine Einwilligung** in der Liste **Empfänger** aufgeführt.

* **Nur eine Mitteilung pro E-Mail-Adresse**: Wählen Sie diese Option, um doppelt vorhandene E-Mail-Adressen aus der Empfängerliste zu entfernen. Diese sind in der Spalte **Status** durch **Duplikat** gekennzeichnet. Dadurch wird die Liste **Empfänger** aktualisiert.

* **Empfängerliste beim Senden aktualisieren**: Wählen Sie diese Option, um die Empfängerlisten vor dem Senden der Kampagne automatisch zu aktualisieren. Siehe im Folgenden **Empfängerlisten aktualisieren**.

* **Firmen einbeziehen**: Wählen Sie diese Option, wenn Firmen als Empfänger einbezogen werden sollen.

    > [!NOTE]
    > Wenn eine Firma keine E-Mail-Adresse hat, wird die Kampagne stattdessen an alle zugehörigen Personen in der Empfängerliste gesendet.

* **Firma bevorzugen**: Wählen Sie diese Option aus, um die Kampagne nur an die Unternehmen in der Empfängerliste (und nicht an die zugehörigen Kontakte) zu senden. Jedes Unternehmen erhält nur eine Kampagne. Kontakte, die nicht zu einer Firma gehören, erhalten weiterhin die Kampagne.

    > [!NOTE]
    > Die Option **Firma bevorzugen** ist nur verfügbar, wenn Sie oben genannte Option **Firmen einbeziehen** ausgewählt haben.

## Kampagnenvorschau

Nachdem Sie Empfänger zur Liste **Empfänger** hinzugefügt haben, können Sie sich eine Vorschau der Kampagne so anzeigen lassen, wie sie ein Empfänger sieht. Die Vorschau ist für Dokument- und SMS-Kampagnen nicht verfügbar.

> [!NOTE]
> Die Kampagne wird in der Vorschau **nicht** an den Empfänger gesendet.

1. Klicken Sie in der Liste **Empfänger** auf einen Empfänger.

2. Klicken Sie auf die Schaltfläche **Vorschau**. Das Fenster **Vorschau** zeigt die Kampagne so an, wie sie für den ausgewählten Empfänger angezeigt wird. Alle Vorlagenvariablen (zum Beispiel Name und Firma) werden durch reale Personendaten ersetzt.

3. Klicken Sie auf Links, um zu überprüfen, ob sie funktionieren. Vergessen Sie jedoch nicht, diese zurückzusetzen, falls sie überwacht werden.

4. Klicken Sie auf X, um das Fenster **Vorschau** zu schließen.

## Liste Empfänger prüfen und aktualisieren

Wenn Sie Selektionen, Projekte und Personen hinzufügen und Listen importieren, wird die Liste **Empfänger** automatisch aktualisiert. Wenn Sie die Option **Empfängerliste beim Senden aktualisieren** ausgewählt haben, werden die Projekte und Selektionen vor dem Senden der Kampagne geprüft, falls Personen hinzugefügt, entfernt oder bearbeitet worden sind.

Zusätzlich dazu können Sie auf die Schaltfläche **Liste aktualisieren** unter der Liste **Empfänger** klicken, um die Liste manuell zu aktualisieren. Einige der Personen in der Liste haben ihre Einwilligung nach dem Hinzufügen möglicherweise geändert.

> [!NOTE]
> In der Liste werden nur die ersten 50 Empfänger angezeigt. Klicken Sie auf **Alle laden** unten in der Liste, um alle Empfänger anzuzeigen.

Klicken Sie auf **Weiter**, um zu Schritt 5 zu gehen: Bestätigen Sie. Sie können immer noch zum Schritt **Empfänger** zurückkehren, um die Empfängerliste zu bearbeiten.

<!-- Referenced images -->
[img3]: ../../../../../../media/loc/en/marketing/add-target-list.png
