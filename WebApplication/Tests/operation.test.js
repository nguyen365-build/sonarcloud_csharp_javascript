const { add, subtract } = require('../Scripts/operation');

test('adds 1 + 2 to equal 3', () => {
    expect(add(1, 2)).toBe(3);

});
test('3 - 2 to equal 1', () => {
    expect(subtract(3, 2)).toBe(1);

});