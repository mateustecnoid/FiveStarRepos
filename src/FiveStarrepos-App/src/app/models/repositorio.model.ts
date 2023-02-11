import { DonoModel } from "./dono.model";
import { LicencaModel } from "./licenca.model";

export class RepositorioModel {
    id: number;
    nome: string;
    nomeCompleto: string;
    privado: boolean;
    url: string;
    descricao: string;
    dataSincronizacao: string;
    dataCriacaoRepositorio: string;
    dataAtualizacaoRepositorio: string;
    tamanho: number;
    stars: number;
    linguagem: string;
    branchPadrao: string;
    dono: DonoModel;
    licenca: LicencaModel
}