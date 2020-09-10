function my_function(message) {
    console.log("from utilities " + message);
}

function dotNetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
    .then(result => {
        console.log("count from javascript " + result);
    })
}

function dotNetInstanceInvocation(dotNetHelper) {
    dotNetHelper.invokeMethodAsync("IncrementCount");
}