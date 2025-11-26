---
uid: help-sv-automation-script-create
title: Skapa skript
description: Skapa skript
author: Bergfrid Dias
date: 03.23.2023
keywords: skript, makro
content_type: howto
language: sv
redirect_from:
  - /sv/automation/crmscript/learn/create-folder
  - /sv/automation/crmscript/learn/create-script
---

# Skapa eller redigera ett skript

## Steps

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Välj **CRMScript** och gör något av följande:
    * Om du vill skapa ett nytt makro: Klicka på **Nytt makro**.
    * Om du vill ändra ett befintligt makro: Klicka på makronamnet.

1. På fliken **Information** kan du redigera eller lägga in information om skriptet:

    * **Mapp**: Välj den mapp du vill spara skriptet i.
    * **Namn**
    * **Beskrivning**
    * **Include-namn**: Ett unikt namn på skriptet som används för att inkludera skriptet i ett annat skript.
    * **Nyckel**: Nyckeln används tillsammans med funktionen "action=parse" på kundsidorna så att du kan köra skript och skapa skriptbaserade funktioner i SuperOffice Kundcenter. Nyckeln förhindrar att godtyckliga skripter kan köras på kundsidorna.
    * **Visa resultat av skriptkörning som HTML**

1. På fliken **Skript** kan du lägga in själva skriptet.

1. (valfritt) Klicka på **Steg** om du vill ha med steg i skriptet. På så sätt kan du testa ändringarna själv.

1. (valfritt) Klicka på **Kör skript** för att köra skriptet. Resultatet visas på fliken **Resultat**.

1. Klicka på **OK**.

## <a id="folder"></a>Egenskaper för makro- eller skriptmapp

Skript- och makromappar används för att organisera dina egna skripter och makron.

### Skapa mapp

1. Klicka på <i class="ph ph-folder" aria-hidden="true"></i> **Ny mapp** högst upp i fönstret.
2. I fältet **Mapp** väljer du en överordnad mapp i listan.
3. Ange ett beskrivande namn på mappen i fältet **Namn**.
4. Klicka på **OK**. Den nya mappen skapas.

### Redigera mapp

Du kan ändra både namnet på en mapp och den information som du angav när du skapade den.

1. Gå till önskad mapp.
2. Klicka på mappens namn.
3. Ändra fälten.
4. Klicka på **OK**. Ändringarna sparas.

### Ta bort mapp

När du tar bort en mapp tas även allt innehåll i mappen (till exempel urval, FAQ-poster, svarsmallar, tabeller, skript och makron) bort från SuperOffice.

1. Gå till önskad mapp.
2. Klicka på mappens namn.
3. Klicka på **Ta bort**.
4. Bekräfta genom att klicka på **OK**. Mappen och dess innehåll tas bort från SuperOffice.

## Relaterat innehåll

* [Om CRMScript][1]
* [Felsök skript][2]
* [Spåra skript][3]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/index.yml
[2]: ../../../../en/automation/crmscript/debugging/built-in-debugger.md
[3]: ../../../../en/automation/crmscript/debugging/using-trace.md

<!-- Referenced images -->
