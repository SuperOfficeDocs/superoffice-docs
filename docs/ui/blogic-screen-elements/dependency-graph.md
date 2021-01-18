---
title: blogic_dependency_graph
description: Dependency graph
author:
so.date:
keywords:
so.topic: reference
---

# Dependency graph

This element displays the dependencies in a project graphically.

Also known as **AcyclicGraph** element.

## Configuration

| Setting           | Description |
|:------------------|:------------|
| createRelationUrl | URL         |
| editRelationUrl   | URL         |

## Functions

### setFieldValue(String action, Map values)

Adds either a node or a dependency.

**addNode:**

| Value       | Description                               |
|:------------|:------------------------------------------|
| dependentOf | a comma-separated list of nodes (Integer) |
| id          | ID of node                                |
| htmlContent | HTML formatted contents of node           |
| color       | HTML color value for node                 |

**addDependency:**

| Value       | Description                 |
|:------------|:----------------------------|
| dependentOf | ID of target node (Integer) |
| relationId  | ID of self                  |
