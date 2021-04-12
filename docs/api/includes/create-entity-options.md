* If you create an entity called A and assign it to an entity called B, when saving B - entity A will be saved through `NestedPersistent`

* you can create an entity that is a property of another entity. Then when saving the main entity, the entity created as the property of it will be saved as well.

Both these would give the same results.