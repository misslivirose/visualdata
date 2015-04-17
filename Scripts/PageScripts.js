function PaintCanvas(string) {
    var renderer = new THREE.WebGLRenderer({ antialias: true });
    renderer.setPixelRatio(window.devicePixelRatio);

    var canvas = renderer.domElement;
    document.body.appendChild(canvas);

    var scene = new THREE.Scene();
    // Create a three.js camera
    var camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.3, 10000);
    camera.position.y = 1;
    var controls = new THREE.VRControls(camera);

    var effect = new THREE.VREffect(renderer);
    effect.setSize(window.innerWidth, window.innerHeight);

    var vrmgr = new WebVRManager(effect);

    // Create 3d objects based on the passed in data
    // Get the number of objects we have
    var obj = $.parseJSON(string);
    var numObjects = obj.rows.length;;
    for (var i = 0; i < numObjects; i++) {
        function createCube() {
            var data_set = obj.rows[i];
            var keys = Object.keys(data_set);
            var yValKey = keys[1];
            var geometry = new THREE.BoxGeometry(1, data_set[yValKey] * .01, 1);
            var material = new THREE.MeshNormalMaterial();
            var cube = new THREE.Mesh(geometry, material);
            cube.position.z = -10;
            cube.position.x = i*2 - numObjects;
            cube.position.y = (data_set[yValKey] * .01) / 2;

            // Add cube mesh to your three.js scene
            scene.add(cube);
        };
        createCube(i);
    }
    // Create a plane for the ground
    var planeMaterial = new THREE.MeshBasicMaterial(
    {
        color: 0xffffff, shading: THREE.FlatShading,
        vertexColors: THREE.VertexColors
    });
    var plane = new THREE.Mesh(new THREE.PlaneGeometry(300, 300), planeMaterial);
    plane.position.y = 0;
    plane.rotation.x = -Math.PI / 2;
    plane.doubleSided = true;
    scene.add(plane);

    if (vrmgr.isVRMode()) {
        effect.render(scene, camera);
    } else {
        renderer.render(scene, camera);
    }
    function animate() {
        // Update VR headset position and apply to camera.
        controls.update();
        // Render the scene through the VREffect, but only if it's in VR mode.
        if (vrmgr.isVRMode()) {
            effect.render(scene, camera);
        } else {
            renderer.render(scene, camera);
        }
        requestAnimationFrame(animate);
    }
    animate();
    // Customize camera move behavior to use WASD for navigation
    document.onkeydown = function (e) {
        if (e.keyCode == 87 ) { // Move forward incrementally with W
            camera.translateZ(-.1);
        }
        else if(e.keyCode == 65) { //Move left incrementally with A
            camera.translateX(-.1);
        }
        else if (e.keyCode == 68) { //Move right incrementally with D
            camera.translateX(.1);
        }
        else if (e.keyCode == 83) { //Move back incrementally with S
            camera.translateZ(.1);
        }

        if(camera.position.y < 0)
        {
            camera.position.y = 1;
        }
    }
}

