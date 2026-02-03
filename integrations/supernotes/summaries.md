---
uid: supernotes-summaries
title: Summaries
description: Common questions about meeting summaries and sharing in Supernotes
keywords: Supernotes, summary, transcript, share meeting summary, speaker, sentiment
author: BredeYabo
date: 02.04.2026
content_type: reference
category: integration
topic: Supernotes
language: en
---

# Summaries

Find answers to common questions about meeting summaries, transcripts, and sharing.

## What status options do meeting summaries have?

Meeting summaries in Supernotes are generated automatically after your meeting ends. The summary goes through the following stages:

| Status | Description |
| --- | --- |
| Processing | Meeting is being transcribed and analyzed. |
| Ready | AI-generated summary is complete and available to view. |
| Shared | Summary has been shared via link or email. |

Once the summary is ready, you can review it, edit if needed, and share it with meeting participants or colleagues.

## What's included in a meeting summary?

Meeting summaries are generated based on the meeting type you've selected. A typical summary includes:

* **Meeting purpose:** why the meeting was held.
* **Key takeaways:** main points and outcomes.
* **Topics discussed:** key discussion points covered.
* **Action items:** tasks identified with responsible parties.
* **Decisions:** key decisions made during the meeting.
* **Next steps:** follow-up items and future plans.
* **Participants:** who attended the meeting.

The specific sections and format depend on your selected meeting type (General, Customer Meeting, Internal Meeting, or custom templates you've created).

You can customize what sections appear by creating custom meeting types in **Settings** > **Meeting Types**.

## <a id="share-summaries"></a>How do I share meeting summaries with participants?

To share a meeting summary:

1. Go to the meeting's summary page.
1. Click **Generate Summary Link**.
1. Do one of the following:
    * Copy the generated link to share manually.
    * Click **Send to all participants** to email everyone.

## What is included in a shareable link?

When you share a meeting summary via a shareable link, the recipient gets full access to:

### Included

* Full meeting summary.
* Complete transcription.
* Speaker statistics (who spoke and for how long).
* Sentiment analysis data.
* Meeting metadata (date, duration, participants).

### Not included

* Editing capabilities - recipients can view but not modify the summary.

Recipients can access all the same information you see, they just cannot make changes to the content.

## How does the meeting chat work after a meeting?

After a meeting ends, you can still use the chatbot to:

* Ask questions about what was discussed.
* Find specific information in the transcript.
* Extract action items or decisions.
* Clarify what someone said about a topic.

### Example queries

* "What decisions were made about the budget?"
* "What did \[person\] say about \[topic\]?"
* "What are the next steps for the project?"

## How do I view the full meeting transcript?

To access the full transcript:

1. Go to the meeting summary page.
1. Click on the **Details & Recording** tab.
1. Select **Transcript**.

### Transcript view features

* Search for specific words or phrases.
* See speaker names with initials.
* View timestamps for each segment.
* Copy transcript text.

## What speaker statistics are available?

The Speakers tab shows detailed analytics for each participant:

| Metric | Description |
| --- | --- |
| Speaking time | Total time and percentage of meeting. |
| Word count | Total words spoken. |
| Words per minute | Speaking pace. |
| Segments | Number of speaking turns. |

### Engagement insights

* **Speaking distribution:** who dominated vs. who was quiet.
* **Participation balance:** balanced, dominant speakers, or quiet participants.

## What is sentiment analysis and how does it work?

Sentiment analysis uses AI to detect the emotional tone of the meeting.

### Overall sentiment

| Sentiment | Meaning |
| --- | --- |
| Neutral | Factual, objective discussion. |
| Positive | Agreement, enthusiasm, contentment. |
| Negative | Disagreement, frustration, concern. |

### Emotion categories

More specific emotions detected, such as:

* **Positive:** Contentment, enthusiasm.
* **Negative:** Confusion, frustration.
* **Neutral:** Neutrality, focus.

This helps identify contentious topics or areas of strong agreement.

## How do I create custom meeting types/templates? {#custom-meeting-types}

Meeting types control how Supernotes formats summaries. To create a custom template:

1. Go to **Settings** > **Meeting Types**.
1. Click **Create new meeting type**.
1. Enter a name and description.
1. Toggle **Share with workspace** if other users should use it.
1. Enter summary instructions in markdown format.
1. Add section headings as needed.
1. Click **Create**.

## How do meeting summary emails work?

Meeting summary emails are sent after your meeting ends to keep you informed.

### Email contents

* The full meeting summary directly in the email.
* Key discussion points and action items.
* Link to view the complete transcription in the portal.

> [!NOTE]
> You can read the summary right from your inbox without needing to log in. For the full transcription and interactive features, click through to the portal.

**To enable:** Go to **Settings** > **Email Preferences** > Enable **Send email summary to me**.

## Why didn't I receive my meeting summary email?

If you didn't receive your meeting summary email, check these possible causes:

* **Email setting disabled:** Go to Settings and ensure "Send email summary to me" is toggled ON.
* **Not the meeting owner:** Summary emails are primarily sent to the meeting owner/organizer.
* **Check your spam folder:** The email may have been filtered.
* **Still processing:** Large meetings may take longer to generate summaries.

### What to do

* Check your Supernotes portal - the summary should be there even if email fails.
* Verify your email settings are correctly configured.
* If the issue persists, contact support.

> [!NOTE]
> Even if you don't receive the email, your summary is always available in the Supernotes portal.

## How do I send a meeting summary to participants via email?

After creating a share link (see [How do I share meeting summaries with participants?][4]), you can email it directly to meeting participants:

1. In the share dialog, click **Send to All** under "Send to Participants".
1. Select which participants should receive the email using the checkboxes.
1. Click **Send to X** to send the summary.

### Tracking who received the email

Participants who have already received the email are shown with a green checkmark and cannot be selected again.

> [!NOTE]
> The email includes the full summary text plus a link to view it in Supernotes. You can send to up to 50 recipients at once.

## How do I share a meeting summary with specific workspace members?

You can grant specific workspace members access to view or edit a meeting summary directly within Supernotes:

1. Open the meeting summary.
1. Click **Manage Access** to open the access management dialog.
1. Switch to the **Grant Access** tab.
1. Search for and select workspace members using the checkboxes.
1. Choose an access level (View, Edit, or Admin).
1. Click **Grant Access** to confirm.

### Available access levels

| Level | Description |
| --- | --- |
| View | Can view the transcription and summary. |
| Edit | Can view and make edits to the transcription. |
| Admin | Can manage access for other users. |

In the "Current Access" tab, you can see everyone who has access, update their access level, or revoke access entirely.

> [!NOTE]
> Only members of your workspace can be added this way. Use share links (see [How do I share meeting summaries with participants?][4]) to share with people outside your workspace.

## Related content

* [Before meeting][1] - Pre-meeting features and preparation
* [Settings][2] - Configuration options
* [Workspaces][3] - Team collaboration and workspace management

<!-- Referenced links -->
[1]: before-meeting.md
[2]: settings.md
[3]: workspaces.md
[4]: #share-summaries
