const map = new Map<string, number>();
map.set('apple',3);
map.set('banana',5);

const appleCount = map.get('apple');
console.log(appleCount);
const hasbanana = map.has('banana');
console.log(hasbanana);