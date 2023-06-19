---
uid: help-de-sync-configure-default-values
title: Sync-Standardwerte konfigurieren
description: Sync-Standardwerte konfigurieren
author: Bergfrid Dias
so.date: 03.29.2023
keywords: Angebot, Sync, Connector, ERP
so.topic: howto
so.user: admin
language: de
---

# Standardwerte für Synchronisation konfigurieren

Sie können den Benutzern viel Zeit ersparen, wenn Sie Standardwerte für Felder eingeben, die typischerweise nur einen relevanten Wert haben. Sie ersparen ihnen damit das Aktivieren eines Feldes, das immer aktiviert sein sollte, oder das Eingeben einer Nummer in ein Feld, das immer die Nummer „30“ enthalten sollte. Dies ist besonders nützlich, wenn große Datenmengen eingegeben werden müssen.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Wählen Sie die ERP-Verbindung aus und klicken Sie unten auf die Schaltfläche **Standards**.

1. Wählen Sie im Dialogfeld die Registerkarte des Aktors aus, für den Sie Standardwerte konfigurieren möchten.

1. Klicken Sie unten im Dialogfeld auf **Hinzu**. Das Dialogfeld **Sync-Standardwert hinzufügen** wird angezeigt.

1. **ERP-Feld**: Hier können Sie auswählen, für welche Felder im ERP-System Sie Standardwerte definieren möchten.

    * **Standardwert festlegen**: Aktivieren Sie diese Option, um einen Standardwert für das ERP-Feld festzulegen, das Sie oben ausgewählt haben. Nachdem Sie diese Option aktiviert haben, können Sie den Standardwert unten festlegen.

    * **Benutzer nach Wert fragen**: Aktivieren Sie diese Option, damit der Benutzer selbst einen Wert eingeben kann.

    * **Obligatorisch - Benutzer muss einen Wert angeben**: Aktivieren Sie diese Option, wenn Sie möchten, dass der Benutzer einen Wert eingeben muss. Wenn das gewählte ERP-Feld obligatorisch ist, wird dieses Feld standardmäßig aktiviert.

1. Klicken Sie auf **OK**.

1. Wiederholen Sie die Schritt 5-6, um weitere Standardwerte hinzuzufügen.
