import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { PaginacaoModel } from "../models/paginacao.model";
import { RepositorioModel } from "../models/repositorio.model";
import { BaseService } from "./base.service";

@Injectable({
    providedIn: 'root'
})
export class RepositorioService extends BaseService {
    constructor(private http: HttpClient) {
        super();
    }

    getRepositorios(paginacao: PaginacaoModel) {
        let params = new HttpParams();
        params = params.append('pagina', `${paginacao.pagina}`);
        params = params.append('tamanhoPagina', `${paginacao.tamanhoPagina}`);

        return this.http.get(this.baseUrl + `Repositorios`, { params: params });
    }

    getRepositorio(id: number) {
        return this.http.get(this.baseUrl + `Repositorios/${id}`);
    }
}