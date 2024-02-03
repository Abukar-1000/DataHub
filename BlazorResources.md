# DataHub

- Web assembly Blazor does send the @code section over to the client in a .dll format.
- Angular & React use full client side, so they can see the source JavaScript used to create components.

#### Render Modes
- RenderModeInteractiveAuto
    - The component will reneder with blazor server to start. Then download the client code, and then run as web assembly on the next run ( This sends over the @code section like React & Angular ).

    - Can not have direct access to backend resources, like:
        - The database
        - Secrets
        - App settings

- RenderModeInteractiveWebAssembly
    - Just like RenderModeInteractive
    
    - There might not be a 1 to 1 alternatives to backend attributes offered on a component on the client side.
    This means you are not gurenteed to have an alternative attribute on a component, if that attribure is originally for server side components.

- RenderModeInteractiveServer
    - Compiles the component on the server and sends over to the client. Has access to all backend resourece.

- StreamRendering
    - Component is built and loaded on the server & then sent over to the client.
    
    - Does not trigger an entire page to be hydrated, only the particular component is compiled on the server
    and re-rendered on the client.

    - Renders the page with initial data so the user can know their request is currently processing.


#### How Blazor Works
- The start of the app is `Program.cs`.

### Communication
- Parent to Child
    - Use properties
    - ```
        [Parameter]
        private string? name = ""
    ```
<br>

- Child To Parent
    - Use event callbacks
        - Create a parameter that will be a callback function passed by the parent.
            - ```
                [Parameter]
                public EventCallback<string> callback { get; set; }
            ```
            - callback is defined in parent, but passed as a parameter here.
        - invoke it using C# labda expressions, as a callback on an event.
            - ```
                <button @onclick = "@( () => callback.InvokeAsync(args) )"> </button>
            ```
            - args are the parameters defined in the function.

- Sibling to Sibling
    - 


### Blazor Life Cycle methods
- onInitialized
- onParameterSet
- onAfterRender

### Resources for Managing State
- [ 🔥 Component Communication (Parameters, EventCallbacks & States/Services) ] (https://www.youtube.com/watch?v=QSM1Vhu1Nsc ' 🔥 Component Communication (Parameters, EventCallbacks & States/Services)')