import 'jasmine';
import { CadastroCandidatoPo } from '../pageObjects/cadastro-candidato.po';

describe('cadastro', async () => {
  let page: CadastroCandidatoPo;

  beforeEach(() => {
    page = new CadastroCandidatoPo();
  });

  it('cadastro de candidato', async () => {

    page.navigateTo();

    expect(await page.cadastrarCandidato()).toEqual('sucesso');

  });
});
