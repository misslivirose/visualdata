function alertFromJSON(string)
{
    alert("JSON Function!");
}

function PaintCanvas() {

    var renderer = new THREE.WebGLRenderer({ antialias: true });
    renderer.setPixelRatio(window.devicePixelRatio);
    document.body.appendChild(renderer.domElement);

    var scene = new THREE.Scene();

    // Create a three.js camera
    var camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.3, 10000);

    var effect = new THREE.VREffect(renderer);
    effect.setSize(window.innerWidth, window.innerHeight);

    var vrmgr = new WebVRManager(effect);

    // Create 3d objects
    var geometry = new THREE.BoxGeometry(0.5, 0.5, 0.5);
    var material = new THREE.MeshNormalMaterial();
    var cube = new THREE.Mesh(geometry, material);
    // Position cube mesh
    cube.position.z = -1;
    // Add cube mesh to your three.js scene
    scene.add(cube);

    if (vrmgr.isVRMode()) {
        effect.render(scene, camera);
    } else {
        renderer.render(scene, camera);
    }
}