"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Candidato = void 0;
var Conhecimento_1 = require("./Conhecimento");
var Preferencia_1 = require("./Preferencia");
var Disponibilidade_1 = require("./Disponibilidade");
var Candidato = /** @class */ (function () {
    function Candidato() {
        this.email = "";
        this.nome = "";
        this.telefone = "";
        this.linkedin = "";
        this.cidade = "";
        this.estado = "";
        this.portfolio = "";
        this.disponibilidade = new Disponibilidade_1.Disponibilidade();
        this.preferencia = new Preferencia_1.Preferencia();
        this.conhecimento = new Conhecimento_1.Conhecimento();
    }
    return Candidato;
}());
exports.Candidato = Candidato;
//# sourceMappingURL=Candidato.js.map