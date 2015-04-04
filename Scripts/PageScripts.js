﻿function alertFromJSON(string) {

  
}

function PaintCanvas(string) {
    var renderer = new THREE.WebGLRenderer({ antialias: true });
    renderer.setPixelRatio(window.devicePixelRatio);
    document.body.appendChild(renderer.domElement);

    var scene = new THREE.Scene();

    // Create a three.js camera
    var camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.3, 10000);

    var effect = new THREE.VREffect(renderer);
    effect.setSize(window.innerWidth, window.innerHeight);

    var vrmgr = new WebVRManager(effect);

    // Create 3d objects based on the passed in data

    var numObjects = numberOfCubes(string);
        // Position cube mesh
        for (var i = 0; i < numObjects; i++)
        {
            var geometry = new THREE.BoxGeometry(1, 1, 1);
            var material = new THREE.MeshNormalMaterial();
            var cube = new THREE.Mesh(geometry, material);
            cube.position.z = -10;
            cube.position.x = i*2;
            // Add cube mesh to your three.js scene
            scene.add(cube);
        }

    if (vrmgr.isVRMode()) {
        effect.render(scene, camera);
    } else {
        renderer.render(scene, camera);
    }

}

function numberOfCubes(string)
{                                                                                                                          
    var obj = $.parseJSON(string);
    return obj.rows.length;

    /** Note: Keep for notes on iterating through JSON
    var data_set = obj.rows[0];

    $.each($.parseJSON(string), function (key, value) {
        count++;
    });
    
    return count; **/
}
