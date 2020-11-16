import { Conhecimento } from "./Conhecimento";
import { Preferencia } from "./Preferencia";
import { Disponibilidade } from "./Disponibilidade";

export class Candidato {
  id: number;
  email: string = "";
  nome: string = "";
  telefone: string = "";
  linkedin: string = "";
  cidade: string = "";
  estado: string = "";
  portfolio: string = "";
  disponibilidade: Disponibilidade = new Disponibilidade();
  preferencia: Preferencia = new Preferencia();
  pretencaoSalario: number;
  conhecimento: Conhecimento = new Conhecimento();

}

