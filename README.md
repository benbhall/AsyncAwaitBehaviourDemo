# AsyncAwaitBehaviourDemo

Simple demo to accompany an article on [my blog](http://benhall.io/), which I wrote to help junior .NET developers understand the behaviour of async/await. 

Just a console application that calls two similar methods, which both in turn call a pretend long running operation.

## WithAwaitAtCallAsync()

The aim here is to counter the surprisingly common misconception: that awaiting will create a thread that excutes the awaited method **in parallel** to the rest of the code continuing. When running this, expect the await to cause the code to block any continutation of WithAwaitAtCallAsync() until the method we are waiting on is complete:

![Animated GIF of async await demo](https://github.com/benbhall/AsyncAwaitBehaviourDemo/blob/master/async_demo2.gif).

### WithoutAwaitAtCallAsync()

If you actually do want the behaviour some expect from the above i.e. you would like to leave the long operation Task completing and continue with WithoutAwaitAtCallAsync(), then simply ommit the await. 

You would get compiler warnings if you simply called without the await but you can prevent these, as I have in the code, by assigning the Task result to a variable. Note though that you must eventually await the result of this Task (the new Task variable) or it will be lost in the ether!