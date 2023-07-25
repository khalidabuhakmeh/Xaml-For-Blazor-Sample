// This file was picked up from https://github.com/conficient/BlazorDynamicScriptLoad
// then modified into a Module so we could load it programmatically.

// loadScript: returns a promise that completes when the script loads
export function loadScript(scriptPath) {
    // check list - if already loaded we can ignore
    if (loaded[scriptPath]) {
        // return 'empty' promise
        return new this.Promise(function (resolve, reject) {
            resolve();
        });
    }

    return new Promise(function (resolve, reject) {
        // create JS library script element
        var script = document.createElement("script");
        script.src = scriptPath;
        script.type = "text/javascript";

        // flag as loading/loaded
        loaded[scriptPath] = true;

        // if the script returns okay, return resolve
        script.onload = function () {
            resolve(scriptPath);
        };

        // if it fails, return reject
        script.onerror = function () {
            console.log(scriptPath + " load failed");
            reject(scriptPath);
        }

        // scripts will load at end of body
        document["head"].appendChild(script);
    });
}
// store list of what scripts we've loaded
var loaded = [];