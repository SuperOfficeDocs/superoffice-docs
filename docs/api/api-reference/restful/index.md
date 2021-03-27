he HTTP WebAPI comes in two parts:
# RESTful WebApi 

## REST Web API

Exposes entities that can be manipulated using the HTTP verbs GET/PUT/POST/DELETE.​

`GET /api/v1/Contact/123`

returns a JSON object representing Contact 123.

`​POST api/v1/List/Category/Items`

adds a new list item to the Category list.

[Download Web API Swagger File](Swagger-v1-REST.json)

## Agents Web API

Contains everything in the normal service API, but does not attempt to model entities. All the web service operations are accessed using HTTP POST.

`POST /api/v1/Agents/Contact/GetContact?contactId=123`

returns a JSON object representing Contact 123.

`POST /api/v1/Agents/List/SaveListItemEntity`

adds a new list item to the Category list (assuming the list item entity parameter has been properly initialized).

[Download Agent Swagger file](Swagger-v1-Agents.json)

The REST API is not as complete as the Agents API, but it should cover the most common use cases, and be easier to use and navigate.

Registering a webhook is covered in the Webhook REST API, and is described in detail in the SuperOffice Webhooks Overview.

Webhook callback events are described in a separate section: Webhooks