// Generic Delegate Implementation of the Observer Pattern

/*
References used: 
https://www.youtube.com/watch?v=yoAOo4dM2pk
https://www.c-sharpcorner.com/article/design-pattern-with-net-delegates/
https://www.devleader.ca/2023/11/17/examples-of-the-observer-pattern-in-c-how-to-simplify-event-management/#google_vignette
*/

using System;

// Define the generic delegate for the event handler
public delegate void EventHandler<T>(T data);