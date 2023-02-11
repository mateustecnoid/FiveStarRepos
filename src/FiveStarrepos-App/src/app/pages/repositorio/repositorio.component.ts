import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RepositorioModel } from 'src/app/models/repositorio.model';
import { RepositorioService } from 'src/app/services/repositorios.service';

@Component({
    selector: 'app-repositorio',
    templateUrl: './repositorio.component.html',
    styleUrls: ['./repositorio.component.css']
})
export class RepositorioComponent implements OnInit {
    id: number;
    repositorio: any;

    constructor(private route: ActivatedRoute,
                private repositorioService: RepositorioService) { }

    ngOnInit(): void {
        this.route.params.subscribe(data => {
            this.id = data["id"];
            this.repositorioService.getRepositorio(data["id"]).subscribe(sub => {
                this.repositorio = sub;
            });
        });
    }

}
