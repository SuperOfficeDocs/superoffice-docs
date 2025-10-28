---
uid: help-sv-add-mailing-domain
title: Lägg till utskicksdomäner
description: Lägg till poster i listan Utskicksdomän
keywords: utskick, domän, SPF
author: digitaldiina
date: 10.28.2025
version: 11.5
content_type: howto
license: marketingessentials
category: Marketing
topic: mailing
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /sv/admin/lists/learn/add-items-to-mailing-domain
language: sv
---

# Lägg till utskicksdomäner

När den globala inställningen **Använd endast godkända e-postutskicksdomäner** är satt till **Ja** kan användarna bara skicka e-post från domäner som har lagts till i denna lista i SuperOffice CRM. Därför är det viktigt att godkända domäner läggs till i listan med en giltig [SPF-post (Sender Policy Framework)][1].

> [!NOTE]
> Den globala inställningen **Använd endast godkända e-postutskicksdomäner** i gruppen **Marknadsföring** måste vara satt till **Ja** för att listan Utskicksdomäner ska kunna användas.

## Steg

1. Klicka på **Listor** under **Inställningar och underhåll** och välj **Utskicksdomäner**.

1. Klicka på **Lägg till** för att lägga till en ny godkänd domän.

1. Lägg till domännamnet och klicka på **Spara**. Systemet gör en SPF-sökning för att kontrollera om domänen har en giltig SPF-post. Om den inte har det visas en varning med information om att utskicksdomäner måste ha en giltig SPF-post. Klicka på **OK** och prova med en annan domän.

1. Om domänen klarar SPF-sökningen läggs den till i listan över godkända domäner och användarna kan göra utskick från domänen.

> [!NOTE]
> Du kan skapa en SPF-post för din domän för att öka chanserna för att organisationens utskick kommer fram (ENDAST ONLINE). Om din miljö är LOKAL görs ingen SPF-sökning. Du kan dock fortfarande använda listan förutsatt att du förser användarna med förkonfigurerade domäner för **Från**- och **Svar till**-adresser.

<!-- Referenced links -->
[1]: ../../../../en/email/mailgun/spf/index.md

<!-- Referenced images -->
