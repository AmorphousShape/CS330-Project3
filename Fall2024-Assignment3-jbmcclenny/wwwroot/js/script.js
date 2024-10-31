const firstNames = [
    "John", "Jane", "Michael", "Emily", "Chris", "Jessica", "David", "Sarah", "James", "Laura"
];

const lastNames = [
    "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez"
];

function getRandomName() {
    const firstName = firstNames[Math.random() % firstNames.length];
    const lastName = lastNames[Math.random() % lastNames.length];
    return `${firstName} ${lastName}`;
}

$(document).ready(function () {

});