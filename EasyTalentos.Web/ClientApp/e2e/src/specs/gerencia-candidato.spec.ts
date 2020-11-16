import 'jasmine';
import { GerenciaCandidatoPoGerenciaCandidatoPo } from '../pageObjects/gerencia-candidato.po';

describe('editar', () => {

  let page: GerenciaCandidatoPoGerenciaCandidatoPo;

  beforeEach(() => {
    page = new GerenciaCandidatoPoGerenciaCandidatoPo();
  });

  it('editar um candidato', async () => {

    page.navigateTo();

    expect(await page.editarCandidato()).toEqual("sucesso");

  });

  it('excluir um candidato', async () => {

    page.navigateTo();

    expect(await page.excluirCandidato()).toEqual("Registro excluido");
  });


});
