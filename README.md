AppWarp_WP7_SDK_DLL
===================

AppWarp client SDK and samples for WP7 and WP8 applications

Check out [AppWarp](http://appwarp.shephertz.com/) to learn more about the product.

[Getting Started](https://github.com/shephertz/AppWarp_WP7_SDK_DLL/wiki/Getting-Started)

[Reference](https://github.com/shephertz/AppWarp_WP7_SDK_DLL/wiki/Reference)

[FAQ](https://github.com/shephertz/AppWarp_JAVA_SDK_JAR/wiki/FAQ)

Sample
========
The sample illustrates how to set up your WP7 project and use the AppWarp SDK. It is a trivial example which shows how user can join the app's zone, create and join
rooms.
Please update the call to WarpClient.initialize with the Api and Secret key pair received while signing up.

V_1.1 update

* remove dependency on NewtonJSON dll
* Added username validation to restrict ;,\/ characters and name length to 25 characters.
