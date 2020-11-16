"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Uteis = void 0;
var Uteis = /** @class */ (function () {
    function Uteis() {
    }
    Uteis.getRandomInt = function (min, max) {
        min = Math.ceil(min);
        max = Math.floor(max);
        return Math.floor(Math.random() * (max - min)) + min;
    };
    return Uteis;
}());
exports.Uteis = Uteis;
//# sourceMappingURL=Uteis.js.map