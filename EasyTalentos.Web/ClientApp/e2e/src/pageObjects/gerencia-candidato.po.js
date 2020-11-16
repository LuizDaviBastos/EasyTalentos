"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.GerenciaCandidatoPoGerenciaCandidatoPo = void 0;
var protractor_1 = require("protractor");
var GerenciaCandidatoPoGerenciaCandidatoPo = /** @class */ (function () {
    function GerenciaCandidatoPoGerenciaCandidatoPo() {
    }
    GerenciaCandidatoPoGerenciaCandidatoPo.prototype.navigateTo = function () {
        protractor_1.browser.get('/gerenciar-candidatos');
    };
    Object.defineProperty(GerenciaCandidatoPoGerenciaCandidatoPo.prototype, "table", {
        get: function () { return protractor_1.element(protractor_1.By.id("tblCandidatos")); },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(GerenciaCandidatoPoGerenciaCandidatoPo.prototype, "buttonOptions", {
        get: function () { return protractor_1.element(protractor_1.By.id("btnOptions")); },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(GerenciaCandidatoPoGerenciaCandidatoPo.prototype, "buttonEditar", {
        get: function () { return protractor_1.element(protractor_1.By.id("btnEditarCandidato")); },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(GerenciaCandidatoPoGerenciaCandidatoPo.prototype, "buttonExcluir", {
        get: function () { return protractor_1.element(protractor_1.By.id("btnExcluirCandidato")); },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(GerenciaCandidatoPoGerenciaCandidatoPo.prototype, "modalCandidato", {
        get: function () { return protractor_1.element(protractor_1.By.id("modalCandidato")); },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(GerenciaCandidatoPoGerenciaCandidatoPo.prototype, "inputNome", {
        get: function () { return protractor_1.element(protractor_1.By.id("inputNome")); },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(GerenciaCandidatoPoGerenciaCandidatoPo.prototype, "buttonSalvar", {
        get: function () { return protractor_1.element(protractor_1.By.id("submit")); },
        enumerable: false,
        configurable: true
    });
    GerenciaCandidatoPoGerenciaCandidatoPo.prototype.editarCandidato = function () {
        return __awaiter(this, void 0, void 0, function () {
            var textoAlert;
            var _this = this;
            return __generator(this, function (_a) {
                switch (_a.label) {
                    case 0:
                        //Espere até que a tabela esteja visível
                        protractor_1.browser.wait(protractor_1.ExpectedConditions.visibilityOf(this.table));
                        this.buttonOptions.click();
                        this.buttonEditar.click();
                        protractor_1.browser.wait(protractor_1.ExpectedConditions.visibilityOf(this.modalCandidato));
                        return [4 /*yield*/, this.inputNome.getAttribute('value').then(function (result) {
                                if (result != "NomeTeste2") {
                                    _this.inputNome.clear();
                                    _this.inputNome.sendKeys("NomeTeste2");
                                }
                                else {
                                    _this.inputNome.clear();
                                    _this.inputNome.sendKeys("NomeTeste1");
                                }
                            })];
                    case 1:
                        _a.sent();
                        this.buttonSalvar.click();
                        protractor_1.browser.wait(protractor_1.ExpectedConditions.alertIsPresent(), 60000);
                        textoAlert = "";
                        return [4 /*yield*/, protractor_1.browser.switchTo().alert().then(function (result) { return __awaiter(_this, void 0, void 0, function () {
                                return __generator(this, function (_a) {
                                    switch (_a.label) {
                                        case 0: return [4 /*yield*/, result.getText()];
                                        case 1:
                                            textoAlert = _a.sent();
                                            result.accept();
                                            return [2 /*return*/];
                                    }
                                });
                            }); })];
                    case 2:
                        _a.sent();
                        return [2 /*return*/, textoAlert];
                }
            });
        });
    };
    GerenciaCandidatoPoGerenciaCandidatoPo.prototype.excluirCandidato = function () {
        return __awaiter(this, void 0, void 0, function () {
            var textAlert;
            var _this = this;
            return __generator(this, function (_a) {
                switch (_a.label) {
                    case 0:
                        //Espere até que a tabela esteja visível
                        protractor_1.browser.wait(protractor_1.ExpectedConditions.visibilityOf(this.table));
                        this.buttonOptions.click();
                        this.buttonExcluir.click();
                        protractor_1.browser.wait(protractor_1.ExpectedConditions.alertIsPresent(), 10000);
                        return [4 /*yield*/, protractor_1.browser.switchTo().alert().then(function (question) {
                                question.accept();
                            })];
                    case 1:
                        _a.sent();
                        protractor_1.browser.wait(protractor_1.ExpectedConditions.alertIsPresent(), 60000);
                        textAlert = "";
                        return [4 /*yield*/, protractor_1.browser.switchTo().alert().then(function (result) { return __awaiter(_this, void 0, void 0, function () {
                                return __generator(this, function (_a) {
                                    switch (_a.label) {
                                        case 0: return [4 /*yield*/, result.getText()];
                                        case 1:
                                            textAlert = _a.sent();
                                            result.accept();
                                            return [2 /*return*/];
                                    }
                                });
                            }); })];
                    case 2:
                        _a.sent();
                        return [2 /*return*/, textAlert];
                }
            });
        });
    };
    return GerenciaCandidatoPoGerenciaCandidatoPo;
}());
exports.GerenciaCandidatoPoGerenciaCandidatoPo = GerenciaCandidatoPoGerenciaCandidatoPo;
//# sourceMappingURL=gerencia-candidato.po.js.map