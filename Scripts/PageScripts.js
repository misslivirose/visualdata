function alertFromJSON(string) {


}

function PaintCanvas(string) {
    var renderer = new THREE.WebGLRenderer({ antialias: true });
    renderer.setPixelRatio(window.devicePixelRatio);

    var canvas = renderer.domElement;
    document.body.appendChild(canvas);

    var scene = new THREE.Scene();

    // Create a three.js camera
    var camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.3, 10000);
    var controls = new THREE.VRControls(camera);

    var effect = new THREE.VREffect(renderer);
    effect.setSize(window.innerWidth, window.innerHeight);

    var vrmgr = new WebVRManager(effect);

    // Create 3d objects based on the passed in data
    // Get the number of objects we have
    var obj = $.parseJSON(string);
    var numObjects = numberOfCubes(obj);
    for (var i = 0; i < numObjects; i++) { 
        createCube(i, obj, scene);   
    }

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
}

function numberOfCubes(obj) {
    return obj.rows.length;
}

function createCube(size, obj, scene)
{
    var i = size;
    var data_set = obj.rows[i];
    var geometry = new THREE.BoxGeometry(1, data_set.price * .01, 1);
    var material = new THREE.MeshNormalMaterial();
    var cube = new THREE.Mesh(geometry, material);
    cube.position.z = -10;
    cube.position.x = i * 2;
    // Add cube mesh to your three.js scene
    scene.add(cube);
}
