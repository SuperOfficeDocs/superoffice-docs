---
title: Unary time-periods
uid: rest_api_search_unary
description: REST Web API search Unary day,week,month,quarter,year
author: {github-id}
keywords: search
so.date:
so.topic: howto
---

# Unary time-periods

## Unary day

### Before today

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date beforeToday HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

### On today

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date today HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

### After today

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date afterToday HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Unary weeks

### Last week

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date lastWeek HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

### This week

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date thisWeek HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

### Next week

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date nextWeek HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Unary months

### Last month

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date lastMonth HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

### This month

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date thisMonth HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

### Next month

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date nextMonth HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Unary quarters

### Last quarter

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date lastQuarter HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

### This quarter

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date thisQuarter HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

### Next quarter

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date nextQuarter HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Unary years

### This half

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date thisHalf HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

### This year

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date thisYear HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```
