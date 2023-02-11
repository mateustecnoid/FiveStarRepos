import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PaginacaoModel } from 'src/app/models/paginacao.model';
import { RepositorioService } from 'src/app/services/repositorios.service';

@Component({
    selector: 'app-repositorios',
    templateUrl: './repositorios.component.html',
    styleUrls: ['./repositorios.component.css']
})
export class RepositoriosComponent implements OnInit {
    repositorios: any;
    paginacao = new PaginacaoModel(1, 10);

    constructor(private repositorioService: RepositorioService,
                private router: Router) { }

    ngOnInit(): void {
        this.obterRepositorios();
    }

    obterRepositorios() {
        this.repositorioService.getRepositorios(this.paginacao).subscribe(sub => {
            this.repositorios = sub;
        });
    }

    proximaPagina() {
        this.paginacao.pagina++;
        this.obterRepositorios();
    }

    paginaAnterior() {
        this.paginacao.pagina === 1 ? this.paginacao.pagina = 1 : this.paginacao.pagina--;
        this.obterRepositorios();
    }

    exibir(id: number) {
        this.router.navigate([`repositorio/${id}`]);
    }
}
